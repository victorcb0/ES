const int led = 10;
const int button = 7;
int value = 0;
int count = 0;
int repeat = 0;

void setup() {
  pinMode(led, OUTPUT);
  pinMode(button, INPUT);
  Serial.begin(9600);
}

void loop() {
  value = digitalRead(button);

  if (value == LOW) {
    repeat = 0;
  }

  if(value == HIGH && repeat == 0)
  {
    count++;
    repeat = 1;
  }
  delay(200);
  
  Serial.println(count);
  if (count == 1) {
    digitalWrite(led, HIGH);
  }
  else
  {
    digitalWrite(led, LOW);
  } 

  if (count == 2)
  {
    Serial.print("Temperatura: ");
    float temperatura = readTempInCelsius(10, 0);
    Serial.print(temperatura);
    Serial.print(" ");
    Serial.write(176);
    Serial.println("C");  
    count = 0;
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
  return sumaTemperatura / (float) count;
}
