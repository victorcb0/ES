// Declararea variabilelor
// Pinii de led au fost conectați la pini digitali cu PWM
const int led_rosu = 11;
const int led_albastru = 10;
const int led_verde = 9;
// Butonul a fost conectat la pinul 7
const int button = 7;
// count e variabila pentru a monitoriza de câte ori e apăsat butonul
int count = 0;
// temperatura e variabila pentru a stoca temperatura actuala
float temperatura = 0;
// tempertaura_old e variabila pentru a stoca temperatura trecuta
float temperatura_old = 0;
// repeat e variabila pentru a nu se schimba variabila count la apăsarea butonului încontinuu
float repeat = 0;

void setup() {
  // Pinii led sunt conectați ca mod OUTPUT
  pinMode(led_rosu, OUTPUT);
  pinMode(led_albastru, OUTPUT);
  pinMode(led_verde, OUTPUT);
  // Pinul butonului este conectat ca mod INPUT
  pinMode(button, INPUT);
  Serial.begin(9600);
}

void loop() {
  // Secvența IF e folosită pentru a nu schimba valoarea variabilei count la apasarea continua a butonului
  if (digitalRead(button) == LOW) {
    repeat = 0;
  }
  // Secventa IF e folosită pentru a crește cu o unitate valoarea variabilei count
  if (digitalRead(button) == HIGH && repeat == 0) {
    count++;
    repeat = 1;
  }
  delay(200);
  
  // Daca valoarea variabilei count este 1, atunci se afișează temperatura și se aprinde ledul albastru si verde
  if (count == 1) {
    // Se salveaza temperatura trecuta
    temperatura_old = temperatura;
    // Se calculează temepratura
    temperatura = readTempInCelsius(10, 0);
    // Dacă este o diferență dintre temperatura trecuta si actuala, atunci se afiseaza 
    if (abs(temperatura_old - temperatura) > 0.25) {
      Serial.print("Temperatura: ");
      Serial.print(temperatura);
      Serial.println(" *C");
    }
    // Se stinge ledul rosu
    digitalWrite(led_rosu, LOW);
    // Se aprinde ledul verde
    digitalWrite(led_verde, HIGH);

    // Se stabilesc intervalele de temperatura (<25; 25-30; 30-35; >35)
    if (temperatura < 25) {
      // Se stabilește intensitatea ledului albastru
      analogWrite(led_albastru, 64);
    }
    else if (temperatura >= 25 && temperatura < 30) {
      analogWrite(led_albastru, 128);
    }
    else if (temperatura >= 30 && temperatura < 35) {
      analogWrite(led_albastru, 196);
    }
    else {
      analogWrite(led_albastru, 255);
    }
  }
  else
  {
    // Daca se mai apasă o data atunci se aprinde ledul rosu si celelalte se sting
    digitalWrite(led_rosu, HIGH);
    digitalWrite(led_verde, LOW);
    digitalWrite(led_albastru, LOW);
    // count se resetează
    count = 0;
  }
}

// Se calculează temperatura senzorului
float readTempInCelsius(int count, int pin) {
  float sumaTemperatura = 0;
  for (int i=0; i<count; i++) {
    int reading = analogRead(pin);
    float voltage = reading * 5.0;
    voltage /= 1024.0;
    float temperaturaCelsius = (voltage - 0.5) * 100;
    sumaTemperatura = sumaTemperatura + temperaturaCelsius;
  }
  return sumaTemperatura / (float)count;
}