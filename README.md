# IMGtoASCII
Projekt wzorowany na projekcie z kanału The Coding Train.

## 1. Wstęp
Prosty projekt mający na celu zapoznanie się z tworzeniem interfejsu graficznego w Windows Forms.
Umożliwia on transformację dowolnego obrazu z formy graficznej do znaków ASCII. 
Taka transformacja pozwala wstawiać obrazy wszędzie tam, gdzie można napisać jakiś komentarz. 
Pozwala to ominąć cenzurę lub jest kreatywnym sposobem na komentowanie lub udostępnianie memów.

## 2. Opis
W programie mamy dostępne jedno okno. Przycisk Load image pozwala załadować obraz do programu. Następnie mamy dwa dostępne przyciski:
- To ASCII: Ten przycisk pozwala na przekształcenie obrazu do znaków ASCII. 
- To ASCII (spaced): Ten przycisk dodaje spację po każdym znaku. Transformacja jest wtedy szersza, dzięki czemu lepiej odwzorowuje faktyczne rozmiary obrazu, ale traci przy tym na czytelności.

Podczas przekształcania analizowany jest każdy kolejny piksel obrazu i wylicza się średnią jego kolorów, która określa jasność. Następnie na tej podstawie określa się jakim znakiem ma zostać zastąpiony dany piksel.
Znaki: Ñ@#W$987654321JI0HA?!abc;:+=-,._(spacja)
