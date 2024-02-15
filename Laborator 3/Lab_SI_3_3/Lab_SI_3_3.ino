int button1Pin = 2;
int led1Pin = 13;
int led2Pin = 12;
int led3Pin = 11;
int led4Pin = 10;

int onoff = 0;
volatile byte state = HIGH;

void setup() {
  pinMode(led1Pin, OUTPUT);
  pinMode(led2Pin, OUTPUT);
  pinMode(led3Pin, OUTPUT);
  pinMode(led4Pin, OUTPUT);
  pinMode(button1Pin, INPUT_PULLUP);
  Serial.begin(115200);
  attachInterrupt(digitalPinToInterrupt(button1Pin), blink1, CHANGE);
}

void blink1()
{
  state = !state;
}

void loop() {
  if (state == LOW) {
    Serial.println("on");
    digitalWrite(led1Pin, HIGH);
    digitalWrite(led2Pin, HIGH);
    digitalWrite(led3Pin, HIGH);
    digitalWrite(led4Pin, HIGH);
    onoff = 1;
  }
  else if (state == HIGH) {
    if (onoff = 1) {
      digitalWrite(led1Pin, LOW);
      digitalWrite(led2Pin, LOW);
      digitalWrite(led3Pin, LOW);
      digitalWrite(led4Pin, LOW);
      onoff = 0;    
    }

    digitalWrite(led1Pin, HIGH);
    delay(1000);

    if (state == LOW) return;
    digitalWrite(led1Pin, LOW);
    digitalWrite(led2Pin, HIGH);
    delay(1000);

    if (state == LOW) return;
    digitalWrite(led2Pin, LOW);
    digitalWrite(led3Pin, HIGH);
    delay(1000);

    if (state == LOW) return;
    digitalWrite(led3Pin, LOW);
    digitalWrite(led4Pin, HIGH);
    delay(1000);

    if (state == LOW) return;
    digitalWrite(led4Pin, LOW);
  }
}