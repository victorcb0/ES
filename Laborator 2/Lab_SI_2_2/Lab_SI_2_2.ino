int c = 0;
int led = 5;
int btn1 = 0;
int btn2 = 1;

void setup() {
  pinMode(led, OUTPUT);
  pinMode(btn1, INPUT);
  pinMode(btn2, INPUT);
}

void loop() {
  analogWrite(led, c);
  if (digitalRead(btn1) == LOW)
  {
    if (c < 255)
    {
      c++;
      delay(50);
    }
  }
  if (digitalRead(btn2) == LOW)
  {
    if(c > 0)
    {
      c--;
      delay(50);
    }
  }
}
