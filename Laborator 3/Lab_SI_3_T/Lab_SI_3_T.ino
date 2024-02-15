const int button = 2;
const int led1_red = 11;
const int led1_blue = 10;
const int led1_green = 9;
const int led2_red = 6;
const int led2_blue = 5;
const int led2_green = 3;

volatile byte state = LOW;
int change = 0;
int onoff = 0;

float temperatura_interior;
float temperatura_exterior;

void setup() {
  pinMode(button, INPUT);
  pinMode(led1_red, OUTPUT);
  pinMode(led1_green, OUTPUT);
  pinMode(led1_blue, OUTPUT);
  pinMode(led2_red, OUTPUT);
  pinMode(led2_green, OUTPUT);
  pinMode(led2_blue, OUTPUT);
  Serial.begin(9600);
  attachInterrupt(digitalPinToInterrupt(button), push, CHANGE);
}

void push() {
  state = !state;
}

void loop() {
  if (state == HIGH && change == 1) {
    onoff = !onoff;
    change = 0;
  }
  if (state == LOW) {
    change = 1;
  }
  
  if (onoff == 1) {
    temperatura_exterior = readTempInCelsius(10, 0);
    temperatura_interior = readTempInCelsius(10, 1);
    
    Serial.print("Temperatura exterior: ");
    Serial.print(temperatura_exterior);
    Serial.write(176);
    Serial.println("C");
    
    Serial.print("Temperatura interior: ");
    Serial.print(temperatura_interior);
    Serial.write(176);
    Serial.println("C");
    
    if (temperatura_exterior > 25 && temperatura_exterior < 30) {
      analogWrite(led1_red, 0);
      analogWrite(led1_green, 255);
      analogWrite(led1_blue, 0);
    }
    else if (temperatura_exterior <= 25) {
      analogWrite(led1_red, 0);
      analogWrite(led1_green, 0);
      analogWrite(led1_blue, 255);
    }
    else if (temperatura_exterior >= 30) {
      analogWrite(led1_red, 255);
      analogWrite(led1_green, 0);
      analogWrite(led1_blue, 0);
    }

    if (temperatura_interior > 15 && temperatura_interior < 25) {
      analogWrite(led2_red, 0);
      analogWrite(led2_green, 255);
      analogWrite(led2_blue, 0);
    }
    else if (temperatura_interior <= 15) {
      analogWrite(led2_red, 0);
      analogWrite(led2_green, 0);
      analogWrite(led2_blue, 255);
    }
    else if (temperatura_interior >=25) {
      analogWrite(led2_red, 255);
      analogWrite(led2_green, 0);
      analogWrite(led2_blue, 0);
    }
  }
  else {
      analogWrite(led1_red, 0);
      analogWrite(led1_green, 0);
      analogWrite(led1_blue, 0);
      
      analogWrite(led2_red, 0);
      analogWrite(led2_green, 0);
      analogWrite(led2_blue, 0);
  }
}

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