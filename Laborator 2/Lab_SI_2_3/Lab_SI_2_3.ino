int inputPin = A0;
int inputValue = 0;
int ledPin = 3;

void setup() {
  pinMode(ledPin, OUTPUT);
}

void loop() {
  inputValue = analogRead(inputPin);

  analogWrite(ledPin, inputValue/4);
}
