using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleQuizGame
{
    public partial class Form1 : Form
    {
        private const int QUESTION_TIME_LIMIT = 15;
        private const int TIMER_INTERVAL = 1000; // 1 second in milliseconds

        private readonly QuizManager quizManager;
        private readonly System.Windows.Forms.Timer questionTimer;
        private int timeLeft = QUESTION_TIME_LIMIT;
        private bool fiftyFiftyUsed = false;
        private bool correctAnswerJokerUsed = false;

        /// <summary>
        /// Initializes the quiz game form and sets up all necessary components
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            quizManager = new QuizManager();
            questionTimer = InitializeTimer();
            SetupQuestion();
            InitializeMoneyList();
            InitializeEventHandlers();
        }
        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }

        /// <summary>
        /// Initializes and configures the question timer
        /// </summary>
        /// <returns>Configured Timer object</returns>
        private System.Windows.Forms.Timer InitializeTimer()
        {
            var timer = new System.Windows.Forms.Timer
            {
                Interval = TIMER_INTERVAL
            };
            timer.Tick += QuestionTimer_Tick;
            return timer;
        }

        /// <summary>
        /// Sets up event handlers for all game control buttons
        /// </summary>
        private void InitializeEventHandlers()
        {
            btnEndGame.Click += btnEndGame_Click;
            btnCorrectAnswerJoker.Click += btnCorrectAnswerJoker_Click;
            btnFiftyFifty.Click += btnFiftyFifty_Click;
        }

        /// <summary>
        /// Prepares and displays the current question with all necessary UI updates
        /// </summary>
        private void SetupQuestion()
        {
            UpdateQuestionDisplay();
            SetupAnswerButtons();
            InitializeTimerDisplay();
            UpdateControlStates();
        }

        /// <summary>
        /// Updates the question text and answer options in the UI
        /// </summary>
        private void UpdateQuestionDisplay()
        {
            var question = quizManager.GetCurrentQuestion();
            lblQuestion.Text = question.Text;
            rbOption1.Text = question.Options[0];
            rbOption2.Text = question.Options[1];
            rbOption3.Text = question.Options[2];
            rbOption4.Text = question.Options[3];
            lblResult.Text = string.Empty;
        }

        /// <summary>
        /// Configures the answer buttons with proper styling and event handlers
        /// </summary>
        private void SetupAnswerButtons()
        {
            Button[] answerButtons = { rbOption1, rbOption2, rbOption3, rbOption4 };
            foreach (var button in answerButtons)
            {
                button.Enabled = true;
                button.BackColor = Color.Indigo;
                button.Click += btnAnswer_Click;
                button.MouseEnter += btnAnswer_MouseEnter;
                button.MouseLeave += btnAnswer_MouseLeave;
            }
        }

        /// <summary>
        /// Initializes and starts the question timer
        /// </summary>
        private void InitializeTimerDisplay()
        {
            timeLeft = QUESTION_TIME_LIMIT;
            lblTimer.Text = $"Time: {timeLeft} seconds";
            questionTimer.Start();
        }

        /// <summary>
        /// Updates the enabled/disabled states of all game controls
        /// </summary>
        private void UpdateControlStates()
        {
            btnNext.Enabled = false;
            btnCheckAnswer.Enabled = true;
            btnFiftyFifty.Enabled = !fiftyFiftyUsed;
            btnCorrectAnswerJoker.Enabled = !correctAnswerJokerUsed;
            quizManager.SelectedAnswer = null;
        }

        /// <summary>
        /// Handles mouse enter event for answer buttons with hover effect
        /// </summary>
        private void btnAnswer_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button hoveredButton && hoveredButton.BackColor != Color.LightGreen)
            {
                hoveredButton.BackColor = Color.MediumPurple;
            }
        }

        /// <summary>
        /// Handles mouse leave event for answer buttons
        /// </summary>
        private void btnAnswer_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button hoveredButton && hoveredButton.BackColor != Color.LightGreen)
            {
                hoveredButton.BackColor = Color.Indigo;
            }
        }

        /// <summary>
        /// Handles the answer button click event
        /// </summary>
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                // Reset all buttons to default color
                rbOption1.BackColor = rbOption2.BackColor = rbOption3.BackColor = rbOption4.BackColor = Color.Indigo;

                // Highlight selected button
                clickedButton.BackColor = Color.LightGreen;

                // Store the selected answer
                quizManager.SelectedAnswer = clickedButton.Text;
            }
        }

        /// <summary>
        /// Handles the timer tick event and updates the time display
        /// </summary>
        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimer.Text = $"Time: {timeLeft} seconds";
            }
            else
            {
                // Stop the timer
                questionTimer.Stop();

                // Update UI
                lblResult.Text = "Time's up!";
                btnCheckAnswer.Enabled = false;

                // Show message to user
                MessageBox.Show("Time's up! Game Over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // End the game
                EndGame();
            }
        }

        /// <summary>
        /// Handles the check answer button click event
        /// </summary>
        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            questionTimer.Stop();

            if (string.IsNullOrEmpty(quizManager.SelectedAnswer))
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            int selectedAnswerIndex = Array.IndexOf(quizManager.GetCurrentQuestion().Options, quizManager.SelectedAnswer);
            bool isCorrect = quizManager.CheckAnswer(selectedAnswerIndex);

            lblResult.Text = isCorrect ? "Correct!" : "Wrong!";
            btnCheckAnswer.Enabled = false;
            btnNext.Enabled = true;

            if (isCorrect)
            {
                quizManager.IncreaseMoneyLevel();
                UpdateMoneyList(quizManager.GetCurrentMoneyIndex());
            }
            else
            {
                MessageBox.Show("Wrong answer! Game Over!");
                EndGame();
            }
        }

        /// <summary>
        /// Handles the next question button click event
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (quizManager.NextQuestion())
            {
                SetupQuestion(); // Use SetupQuestion instead of just UpdateQuestionDisplay
            }
            else
            {
                MessageBox.Show("Congratulations! You've completed the quiz!");
                EndGame();
            }
        }

        /// <summary>
        /// Ends the game and disables all controls
        /// </summary>
        private void EndGame()
        {
            // Stop the timer
            questionTimer.Stop();

            // Disable all game controls
            btnCheckAnswer.Enabled = false;
            btnNext.Enabled = false;
            btnFiftyFifty.Enabled = false;
            btnCorrectAnswerJoker.Enabled = false;
            rbOption1.Enabled = false;
            rbOption2.Enabled = false;
            rbOption3.Enabled = false;
            rbOption4.Enabled = false;

            // Show final result
            lblQuestion.Text = "Game Over!";
            string finalMoney = lstMoneyLevels.Items[quizManager.GetCurrentMoneyIndex()].ToString();
            lblResult.Text = $"Final Prize: {finalMoney}";

            // Enable only the End button
            btnEndGame.Enabled = true;
        }

        /// <summary>
        /// Handles the end game button click event
        /// </summary>
        private void btnEndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the fifty-fifty joker button click event
        /// </summary>
        private void btnFiftyFifty_Click(object sender, EventArgs e)
        {
            if (fiftyFiftyUsed)
            {
                MessageBox.Show("50/50 joker is being used!");
                return;
            }

            fiftyFiftyUsed = true;
            var wrongAnswers = quizManager.UseFiftyFiftyJoker();
            Button[] options = { rbOption1, rbOption2, rbOption3, rbOption4 };
            foreach (int wrongAnswer in wrongAnswers)
            {
                options[wrongAnswer].Enabled = false;
                options[wrongAnswer].Text = "";
            }

            btnFiftyFifty.Enabled = false;
        }

        /// <summary>
        /// Initializes the money levels list with all possible prize amounts
        /// </summary>
        private void InitializeMoneyList()
        {
            lstMoneyLevels.Items.Clear();
            lstMoneyLevels.Items.AddRange(quizManager.GetMoneyLevels());
            UpdateMoneyList(quizManager.GetCurrentMoneyIndex());
        }

        /// <summary>
        /// Updates the selected index in the money levels list
        /// </summary>
        /// <param name="currentIndex">Current money level index</param>
        private void UpdateMoneyList(int currentIndex)
        {
            if (currentIndex >= 0 && currentIndex < lstMoneyLevels.Items.Count)
            {
                lstMoneyLevels.SelectedIndex = currentIndex;
            }
        }

        /// <summary>
        /// Handles the drawing of money levels list items
        /// </summary>
        private void lstMoneyLevels_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index == quizManager.CurrentLevel)
            {
                // Highlight current prize level in green
                e.Graphics.FillRectangle(Brushes.Green, e.Bounds);
                e.Graphics.DrawString(lstMoneyLevels.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds);
            }
            else
            {
                // Draw other levels in purple
                e.Graphics.FillRectangle(Brushes.Purple, e.Bounds);
                e.Graphics.DrawString(lstMoneyLevels.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Handles the correct answer joker button click event
        /// </summary>
        private void btnCorrectAnswerJoker_Click(object sender, EventArgs e)
        {
            if (correctAnswerJokerUsed)
            {
                MessageBox.Show("Correct answer joker is being used!");
                return;
            }

            correctAnswerJokerUsed = true;
            int correctAnswerIndex = quizManager.GetCorrectAnswerIndex();
            Button[] options = { rbOption1, rbOption2, rbOption3, rbOption4 };
            options[correctAnswerIndex].BackColor = Color.LightGreen;

            btnCorrectAnswerJoker.Enabled = false;
        }
    }
}
