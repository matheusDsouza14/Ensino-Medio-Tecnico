int speakerPin = 10; // Define o pino do speaker como o pino 10
void setup() {
  pinMode(speakerPin, OUTPUT); // Define o pino do speaker como saída
  }
void loop() {     
    tone(speakerPin, 1000);     
    delay(1000);       
    noTone(speakerPin);
    delay(1000);
}