namespace SimpleQuizGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFiftyFifty = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnCorrectAnswerJoker = new System.Windows.Forms.Button();
            this.lstMoneyLevels = new System.Windows.Forms.ListBox();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.rbOption1 = new System.Windows.Forms.Button();
            this.rbOption2 = new System.Windows.Forms.Button();
            this.rbOption3 = new System.Windows.Forms.Button();
            this.rbOption4 = new System.Windows.Forms.Button();
            this.panelQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(2, 2);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(391, 59);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Location = new System.Drawing.Point(155, 61);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 1;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAnswer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.ForeColor = System.Drawing.Color.White;
            this.btnCheckAnswer.Location = new System.Drawing.Point(341, 432);
            this.btnCheckAnswer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(100, 70);
            this.btnCheckAnswer.TabIndex = 2;
            this.btnCheckAnswer.Text = "Check";
            this.btnCheckAnswer.UseVisualStyleBackColor = false;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.DarkViolet;
            this.lblTimer.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(40, 140);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 27);
            this.lblTimer.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(640, 423);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 50);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFiftyFifty
            // 
            this.btnFiftyFifty.BackColor = System.Drawing.Color.DarkBlue;
            this.btnFiftyFifty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiftyFifty.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiftyFifty.ForeColor = System.Drawing.Color.White;
            this.btnFiftyFifty.Location = new System.Drawing.Point(73, 247);
            this.btnFiftyFifty.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFiftyFifty.Name = "btnFiftyFifty";
            this.btnFiftyFifty.Size = new System.Drawing.Size(100, 70);
            this.btnFiftyFifty.TabIndex = 10;
            this.btnFiftyFifty.Text = "50:50";
            this.btnFiftyFifty.UseVisualStyleBackColor = false;
            this.btnFiftyFifty.Click += new System.EventHandler(this.btnFiftyFifty_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.DarkBlue;
            this.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndGame.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.ForeColor = System.Drawing.Color.White;
            this.btnEndGame.Location = new System.Drawing.Point(640, 489);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(100, 50);
            this.btnEndGame.TabIndex = 11;
            this.btnEndGame.Text = "End";
            this.btnEndGame.UseVisualStyleBackColor = false;
            // 
            // btnCorrectAnswerJoker
            // 
            this.btnCorrectAnswerJoker.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCorrectAnswerJoker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrectAnswerJoker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrectAnswerJoker.ForeColor = System.Drawing.Color.White;
            this.btnCorrectAnswerJoker.Location = new System.Drawing.Point(73, 349);
            this.btnCorrectAnswerJoker.Name = "btnCorrectAnswerJoker";
            this.btnCorrectAnswerJoker.Size = new System.Drawing.Size(100, 70);
            this.btnCorrectAnswerJoker.TabIndex = 12;
            this.btnCorrectAnswerJoker.Text = "Safe";
            this.btnCorrectAnswerJoker.UseVisualStyleBackColor = false;
            this.btnCorrectAnswerJoker.Click += new System.EventHandler(this.btnCorrectAnswerJoker_Click);
            // 
            // lstMoneyLevels
            // 
            this.lstMoneyLevels.BackColor = System.Drawing.Color.Indigo;
            this.lstMoneyLevels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstMoneyLevels.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMoneyLevels.ForeColor = System.Drawing.Color.White;
            this.lstMoneyLevels.FormattingEnabled = true;
            this.lstMoneyLevels.ItemHeight = 20;
            this.lstMoneyLevels.Location = new System.Drawing.Point(608, 128);
            this.lstMoneyLevels.Name = "lstMoneyLevels";
            this.lstMoneyLevels.Size = new System.Drawing.Size(150, 264);
            this.lstMoneyLevels.TabIndex = 13;
            this.lstMoneyLevels.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstMoneyLevels_DrawItem);
            // 
            // panelQuestion
            // 
            this.panelQuestion.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuestion.Controls.Add(this.lblQuestion);
            this.panelQuestion.Controls.Add(this.lblResult);
            this.panelQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelQuestion.ForeColor = System.Drawing.Color.White;
            this.panelQuestion.Location = new System.Drawing.Point(181, 140);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(400, 100);
            this.panelQuestion.TabIndex = 14;
            // 
            // picLogo
            // 
            this.picLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLogo.ErrorImage")));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(260, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(230, 140);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;

            // 
            // rbOption1
            // 
            this.rbOption1.BackColor = System.Drawing.Color.Indigo;
            this.rbOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbOption1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption1.ForeColor = System.Drawing.Color.White;
            this.rbOption1.Location = new System.Drawing.Point(212, 283);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(150, 50);
            this.rbOption1.TabIndex = 16;
            this.rbOption1.UseVisualStyleBackColor = false;
            this.rbOption1.Click += new System.EventHandler(this.btnAnswer_Click);
            this.rbOption1.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.rbOption1.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);
            // 
            // rbOption2
            // 
            this.rbOption2.BackColor = System.Drawing.Color.Indigo;
            this.rbOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbOption2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption2.ForeColor = System.Drawing.Color.White;
            this.rbOption2.Location = new System.Drawing.Point(399, 283);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(150, 50);
            this.rbOption2.TabIndex = 17;
            this.rbOption2.UseVisualStyleBackColor = false;
            this.rbOption2.Click += new System.EventHandler(this.btnAnswer_Click);
            this.rbOption2.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.rbOption2.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);
            // 
            // rbOption3
            // 
            this.rbOption3.BackColor = System.Drawing.Color.Indigo;
            this.rbOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbOption3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption3.ForeColor = System.Drawing.Color.White;
            this.rbOption3.Location = new System.Drawing.Point(212, 360);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(150, 50);
            this.rbOption3.TabIndex = 18;
            this.rbOption3.UseVisualStyleBackColor = false;
            this.rbOption3.Click += new System.EventHandler(this.btnAnswer_Click);
            this.rbOption3.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.rbOption3.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);
            // 
            // rbOption4
            // 
            this.rbOption4.BackColor = System.Drawing.Color.Indigo;
            this.rbOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbOption4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption4.ForeColor = System.Drawing.Color.White;
            this.rbOption4.Location = new System.Drawing.Point(399, 359);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(150, 50);
            this.rbOption4.TabIndex = 19;
            this.rbOption4.UseVisualStyleBackColor = false;
            this.rbOption4.Click += new System.EventHandler(this.btnAnswer_Click);
            this.rbOption4.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.rbOption4.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.rbOption4);
            this.Controls.Add(this.rbOption3);
            this.Controls.Add(this.rbOption2);
            this.Controls.Add(this.rbOption1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.lstMoneyLevels);
            this.Controls.Add(this.btnCorrectAnswerJoker);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnFiftyFifty);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnCheckAnswer);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Who wants to be a Millionar?";
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.ClientSize = new System.Drawing.Size(1000, 700);

            // Update control positions and sizes
            this.panelQuestion.Location = new System.Drawing.Point(250, 140);
            this.panelQuestion.Size = new System.Drawing.Size(500, 120);

            this.lblTimer.Location = new System.Drawing.Point(250, 80);
            this.lblTimer.Size = new System.Drawing.Size(200, 30);
            this.lblTimer.AutoSize = false;

            // Answer buttons
            this.rbOption1.Location = new System.Drawing.Point(250, 280);
            this.rbOption1.Size = new System.Drawing.Size(220, 60);

            this.rbOption2.Location = new System.Drawing.Point(530, 280);
            this.rbOption2.Size = new System.Drawing.Size(220, 60);

            this.rbOption3.Location = new System.Drawing.Point(250, 360);
            this.rbOption3.Size = new System.Drawing.Size(220, 60);

            this.rbOption4.Location = new System.Drawing.Point(530, 360);
            this.rbOption4.Size = new System.Drawing.Size(220, 60);

            // Lifeline buttons
            this.btnFiftyFifty.Location = new System.Drawing.Point(50, 280);
            this.btnFiftyFifty.Size = new System.Drawing.Size(120, 60);

            this.btnCorrectAnswerJoker.Location = new System.Drawing.Point(50, 360);
            this.btnCorrectAnswerJoker.Size = new System.Drawing.Size(120, 60);

            // Check answer button
            this.btnCheckAnswer.Location = new System.Drawing.Point(380, 450);
            this.btnCheckAnswer.Size = new System.Drawing.Size(120, 60);

            // Navigation buttons
            this.btnNext.Location = new System.Drawing.Point(830, 280);
            this.btnNext.Size = new System.Drawing.Size(120, 60);

            this.btnEndGame.Location = new System.Drawing.Point(830, 360);
            this.btnEndGame.Size = new System.Drawing.Size(120, 60);

            // Money list
            this.lstMoneyLevels.Location = new System.Drawing.Point(800, 80);
            this.lstMoneyLevels.Size = new System.Drawing.Size(180, 180);

            // Logo
            this.picLogo.Location = new System.Drawing.Point(380, 10);
            this.picLogo.Size = new System.Drawing.Size(240, 60);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFiftyFifty;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Button btnCorrectAnswerJoker;
        private System.Windows.Forms.ListBox lstMoneyLevels;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button rbOption1;
        private System.Windows.Forms.Button rbOption2;
        private System.Windows.Forms.Button rbOption3;
        private System.Windows.Forms.Button rbOption4;
    }
}
