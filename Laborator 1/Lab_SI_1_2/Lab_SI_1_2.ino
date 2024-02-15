const int led = 10;
const int button = 7;
int value = 0;

void setup()
{
	pinMode(led, OUTPUT);
	pinMode(button, INPUT);
}

void loop()
{
	value = digitalRead(button);
  	if (value == HIGH)
    {
    	digitalWrite(led, HIGH);
    }
    else 
    {
    	digitalWrite(led,LOW);
    }
}