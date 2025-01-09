# Wer wird Millionär Quiz-Spiel
Eine Windows Forms-Anwendung, die das klassische TV-Show-Quiz-Erlebnis mit C# nachbildet.

## Überblick
Dieses Spiel simuliert die TV-Show "Wer wird Millionär", bei der Spieler zunehmend schwierigere Fragen beantworten müssen, um virtuelles Geld zu gewinnen. Die Anwendung wurde unter Verwendung moderner Softwareentwicklungspraktiken entwickelt und folgt einem sauberen Architekturmuster.

## Technische Details

### Architektur
Die Anwendung folgt einer Drei-Schichten-Architektur:

* **Präsentationsschicht (UI)**
   * Windows Forms-Benutzeroberfläche
   * Echtzeit-Visualisierungsaktualisierungen
   * Behandlung der Benutzerinteraktionen

* **Geschäftslogikschicht**
   * Verwaltung der Spiellogik
   * Fragenbehandlung
   * Punkteberechnung
   * Timer-Steuerung

* **Datenschicht**
   * Fragenspeicherung
   * Verwaltung des Spielzustands
   * Punkteverfolgung

## Funktionen
- Multiple-Choice-Fragen mit vier Antwortmöglichkeiten
- Timer für jede Frage
- Aufsteigende Gewinnstufen von 100€ bis 1.000.000€
- Zwei Joker:
  - 50:50: Entfernt zwei falsche Antworten
  - Sichere Antwort: Zeigt die richtige Antwort
- Echtzeit-visuelle Rückmeldung
- Verfolgung des Geldfortschritts

## Spielanleitung
1. Starte das Spiel
2. Lies jede Frage sorgfältig
3. Wähle deine Antwort innerhalb des Zeitlimits
4. Setze Joker bei Bedarf ein
5. Steige die Gewinnstufen hinauf
6. Versuche die Million zu erreichen!

## Spielregeln
- Jede Frage hat ein Zeitlimit von 15 Sekunden
- Falsche Antworten beenden das Spiel
- Joker können nur einmal pro Spiel verwendet werden
- Die Fragen werden zunehmend schwieriger
- Höhere Stufen bieten größere Gewinne
