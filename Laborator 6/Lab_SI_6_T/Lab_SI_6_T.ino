// Includerea bibliotecii care operează cu senzorul DHT11
#include <DHT.h>

// Definirea pinilor analogici ai senzorilor DHT11
#define DHTpin A0
#define DHTpin2 A1

// Definirea unei enumerații care reprezintă stările unui led RGB
enum StareRGB {RosuRGB, VerdeRGB, AlbastruRGB, Oprit};

// Declararea clasei Bec
class Bec
{
  private:
    // Declararea variabilei pin
  	byte pin;
    // Declararea variabilei stare
  	bool stare = 0;

  public:
    // Declararea funcțiilor clasei Bec
    Bec(byte pin);
    void Schimba();
    void Off();
    void On();
    bool Stare();
};

// Definirea constructorului clasei Bec 
Bec::Bec(byte pin) {
  // Setarea variabilei pin
  this->pin = pin;
  // Definirea modului pinului ca fiind OUTPUT
  pinMode(pin, OUTPUT);
}

// Definirea funcției Schimba a clasei Bec
void Bec::Schimba() {
  // Schimbă starea pe cea opusă
  this->stare = !this->stare;
  // In dependență de stare schimbă pinul ca fiind pe HIGH sau LOW
  if (this->stare)
    digitalWrite(this->pin, HIGH);
  else
    digitalWrite(this->pin, LOW);
}

// Definirea functiei Off a clasei Bec
void Bec::Off() {
  // În dependență de stare apelează funcția Schimba
  if (this->stare) {
    this->Schimba();
  }
}

// Definirea functiei Off a clasei Bec
void Bec::On() {
  if (!this->stare) {
    // În dependență de stare apelează funcția Schimbă
    this->Schimba();
  }
}

// Definirea funcției Stare a clasei Bec
bool Bec::Stare() {
  // Returnează variabila stare
  return this->stare;
}

// Declararea clasei BecRGB
class BecRGB
{
  private:
    // Declararea unui array pini
  	byte pini[3];
    // Declararea variabilei stare
  	byte stare = 0;

  public:
    // Declararea funcțiilor clasei BecRGB
    BecRGB(byte pinRosu, byte pinVerde, byte pinAlbastru);
    void Off();
    void Rosu();
    void Verde();
    void Albastru();
    bool Stare();
};

// Definirea constructorului clasei BecRGB
BecRGB::BecRGB(byte pinRosu, byte pinVerde, byte pinAlbastru) {
  // Setarea array-ului pini
  this->pini[RosuRGB] = pinRosu;
  this->pini[VerdeRGB] = pinVerde;
  this->pini[AlbastruRGB] = pinAlbastru;
  // Setarea modului pinilor ca fiind de tip OUTPUT
  for(int i=0; i<3; i++)
    pinMode(this->pini[i], OUTPUT);
}

// Definirea funcției Off a clasei BecRGB
void BecRGB::Off() {
  // In dependență de stare, setează toți pinii pe 0
  if (this->stare != Oprit) {
    analogWrite(pini[RosuRGB], 0);
    analogWrite(pini[VerdeRGB], 0);
    analogWrite(pini[AlbastruRGB], 0);
    // Shimbă variabila stare pe 0
    this->stare = Oprit;
  }
}

// Definirea funcției Rosu a clasei BecRGB
void BecRGB::Rosu() {
  // In dependență de stare, setează pinul Rosu pe 255
  if (this->stare != RosuRGB) {
    analogWrite(pini[RosuRGB], 255);
    analogWrite(pini[VerdeRGB], 0);
    analogWrite(pini[AlbastruRGB], 0);
    // Shimbă variabila stare pe 1
    this->stare = RosuRGB;
  }
}

// Definirea funcției Rosu a clasei BecRGB
void BecRGB::Verde() {
  // In dependență de stare, setează pinul Verde pe 255
  if (this->stare != VerdeRGB) {
    analogWrite(pini[RosuRGB], 0);
    analogWrite(pini[VerdeRGB], 255);
    analogWrite(pini[AlbastruRGB], 0);
    // Shimbă variabila stare pe 2
    this->stare = VerdeRGB;
  }
}

// Definirea funcției Rosu a clasei BecRGB
void BecRGB::Albastru() {
  // In dependență de stare, setează pinul Verde pe 255
  if (this->stare != AlbastruRGB) {
    analogWrite(pini[RosuRGB], 0);
    analogWrite(pini[VerdeRGB], 0);
    analogWrite(pini[AlbastruRGB], 255);
    // Shimbă variabila stare pe 3
    this->stare = AlbastruRGB;
  }
}

// Definirea funcției Stare a clasei BecRGB
bool BecRGB::Stare() {
  // Returnează variabila stare
  return this->stare;
}

// Crearea variabile becRosu de tipul Bec
Bec becRosu(3);
// Crearea variabile becRGBInterior de tipul BecRGB
BecRGB becRGBInterior(7, 5, 4);
// Crearea variabile becRGBExterior de tipul BecRGB
BecRGB becRGBExterior(13, 11, 10);
// Crearea varibilei stare pentru intreruperea sistemului
volatile byte stare = LOW;
// Declararea varibilelor pentru senzorii DHT11
DHT dhtInterior(A0, DHT11);
DHT dhtExterior(A1, DHT11);
// Declararea variabilelor pentru memorarea datelor de la senzor
float TemperaturaInterior;
float TemperaturaExterior;
float UmiditateInterior;
float UmiditateExterior;
float IndexCalduraInterior;
float IndexCalduraExterior;
// Declarare variabilei change pentru a memora trecerea la valorea LOW a întreruperii
int change = 0;
// Declarare variabilei change pentru a memora trecerea starea sistemului
int onoff = 0;

void setup() {
  // Declarearea întreruperii sistemului
  attachInterrupt(digitalPinToInterrupt(2), stop, CHANGE);
  // Declarearea Serial Monitor
  Serial.begin (115200);
  // Afișarea pe Serial Monitor ”Oprit!”
  Serial.println(F("Oprit!"));
  // Inițializarea senzorilor DHT11
  dhtInterior.begin();
  dhtExterior.begin();
}

// Definirea funției stop pentru întrerupere
void stop() {
  stare = !stare;
}
                
void loop() {
  // Dacă butonul e apăsat și anterior a fost LOW atunci se schimbă starea sistemului
  if (stare == HIGH && change == 1) {
    onoff = !onoff;
    change = 0;
  }
  // Dacă valoarea e LOW se schimba valoarea change 
  if (stare == LOW) {
    change = 1;
  }

  // Dacă starea sistemului este 1 atunci se îndeplinesc următoarele condiții
  if (onoff == 1) {
    // Se citesc valorile pe de senzori
    TemperaturaInterior = dhtInterior.readTemperature();
    UmiditateInterior = dhtInterior.readHumidity();
    IndexCalduraInterior = dhtInterior.computeHeatIndex(TemperaturaInterior, UmiditateInterior, false);
    TemperaturaExterior = dhtExterior.readTemperature();
    UmiditateExterior = dhtExterior.readHumidity();
    IndexCalduraExterior = dhtExterior.computeHeatIndex(TemperaturaExterior, UmiditateExterior, false);

    // Se scrie pe println într-un format pentru aplicația C#
    Serial.println((String) TemperaturaInterior + "T" 
                  + UmiditateInterior + "H" 
                  + IndexCalduraInterior + "I" 
                  + TemperaturaExterior + "TT" 
                  + UmiditateExterior + "HH" 
                  + IndexCalduraExterior + "II");

    // Dacă temperatura din interior este între 25 și 27, atunci becul RGB se schimbă pe verde
    if (TemperaturaInterior > 25 && TemperaturaInterior < 27)
      becRGBInterior.Verde();
    // Dacă temperatura din interior este mai mică sau egală cu 25, atunci becul RGB se schimbă pe albastru
    else if (TemperaturaInterior <= 25)
      becRGBInterior.Albastru();
    // Dacă temperatura din interior este mai mare sau egală cu 27, atunci becul RGB se schimbă pe roșu
    else if (TemperaturaInterior >= 27)
      becRGBInterior.Rosu();

    // Dacă temperatura din exterior este între 25 și 27, atunci becul RGB se schimbă pe verde
    if (TemperaturaExterior > 25 && TemperaturaExterior < 27)
      becRGBExterior.Verde();
    // Dacă temperatura din exterior este mai mică sau egală cu 25, atunci becul RGB se schimbă pe albastru
    else if (TemperaturaExterior <= 25)
      becRGBExterior.Albastru();
    // Dacă temperatura din exterior este mai mare sau egală cu 27, atunci becul RGB se schimbă pe roșu
    else if (TemperaturaExterior >= 27)
      becRGBExterior.Rosu();
    // Becul roșu se stinge
    becRosu.Off();    
  }
  else {
    // Becurile RGB se sting
    becRGBInterior.Off();
    becRGBExterior.Off();
    // Becul roșu se aprinde
    becRosu.On();
  }
}