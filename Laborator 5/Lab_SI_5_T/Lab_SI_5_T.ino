enum color {VERDE, GALBEN, ROSU};

class Semafor
{
  public:
    Semafor(byte pinRosu, byte pinGalben, byte pinVerde);
    void Toggle(int color);
    void TurnOff(int color);
    void TurnOn(int color);
    void Go();
    void Careful();
    void Stop();
    bool GetState(int color);
  
  private:
  	byte pins[3];
  
  	bool states[3] = {0};
  	
  	void init();
};
  
void Semafor::init() {
  for(int i=0; i<3; i++) {
    pinMode(this->pins[i], OUTPUT);
  }
}

Semafor::Semafor(byte pinRosu, byte pinGalben, byte pinVerde) {
  this->pins[ROSU] = pinRosu;
  this->pins[GALBEN] = pinGalben;
  this->pins[VERDE] = pinVerde;
  this->init();
}

bool Semafor::GetState(int color) {
  return this->states[color];
}

void Semafor::Toggle(int color) {
  this->states[color] = !this->states[color];
  if (this->states[color]) {
    digitalWrite(this->pins[color], HIGH);
  } else {
    digitalWrite(this->pins[color], LOW);
  }
}

void Semafor::TurnOn(int color) {
  if (!this->states[color]) {
    this->Toggle(color);
  }
}

void Semafor::TurnOff(int color) {
  if (this->states[color]) {
    this->Toggle(color);
  }
}

void Semafor::Go() {
  this->TurnOff(GALBEN);
  this->TurnOff(ROSU);
  this->TurnOn(VERDE);
}

void Semafor::Careful() {
  this->TurnOff(ROSU);
  this->TurnOff(VERDE);
  this->TurnOn(GALBEN);
}

void Semafor::Stop() {
  this->TurnOff(GALBEN);
  this->TurnOff(VERDE);
  this->TurnOn(ROSU);
}

Semafor semaforMasini(11, 10, 9);
Semafor semaforPietoni(8, 0, 7);

const int buttonPin = 2;
const int difuzorPin = 13;
volatile byte buttonState = LOW;

void setup() {
  pinMode(difuzorPin, OUTPUT);
  pinMode(buttonPin, INPUT_PULLUP);
  attachInterrupt(digitalPinToInterrupt(buttonPin), stop, CHANGE);
}
       
void stop() {
  buttonState = !buttonState;
}
                    
void loop() { 
  if (buttonState == LOW)
    timp();
  else {
  	semaforMasini.Stop();
    semaforPietoni.Go();
  }

}
             
void timp() {
  semaforMasini.Stop();
  semaforPietoni.Go();
  tone(difuzorPin, 500, 100);   
  timp3(30);
  if (buttonState == HIGH)
    return;
  semaforPietoni.Stop();
  timp2(10);
  if (buttonState == HIGH)
    return;
  semaforMasini.Go();
  timp2(60);
  if (buttonState == HIGH)
    return;
  semaforMasini.Careful();
  timp2(20);
  if (buttonState == HIGH)
    return;
}

void timp2(int nr) {
  for (int i = 0; i < nr; i++) {
    tone(difuzorPin, 500, 1000);
    delay(100);
    if (buttonState == HIGH)
      return;
  }
}

void timp3(int nr) {
  for (int i = 0; i < nr; i++) {
    tone(difuzorPin, 1000, 50);
    delay(100);
    if (buttonState == HIGH)
      return;
  }
}