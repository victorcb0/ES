int buttonPin = 3;
int ledPin = 13;

volatile int buttonState = 0;

void setup() {
  pinMode(ledPin, OUTPUT);
  pinMode(buttonPin, INPUT);

  attachInterrupt(digitalPinToInterrupt(buttonPin), pin_ISR, CHANGE);
}

void pin_ISR() {
  buttonState = !buttonState;
}

void loop() {
  digitalWrite(ledPin, buttonState);
}