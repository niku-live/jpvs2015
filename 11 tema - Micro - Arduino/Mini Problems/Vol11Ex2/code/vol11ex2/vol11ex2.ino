const int NbrLEDs = 8; //lempuciu skaicius
const int ledPins[] = { 5, 6, 7, 8, 9, 10, 11, 12}; //kur lemputes pajungtos
const int photocellPin = A0; //kur pajungtas sviesos rezistorius
                             
const int wait = 30;

const boolean LED_ON = HIGH;
const boolean LED_OFF = LOW;

int sensorValue = 0;        // value read from the sensor
int ledLevel = 0;           // sensor value converted into LED 'bars'

void setup() {
  for (int led = 0; led < NbrLEDs; led++)
  {
    pinMode(ledPins[led], OUTPUT);
  }
}

void loop() {
  sensorValue = analogRead(photocellPin);
  ledLevel = map(sensorValue, 300, 1023, 0, NbrLEDs);
  for (int led = 0; led < NbrLEDs; led++)
  {
    if (led < ledLevel ) {
      digitalWrite(ledPins[led], LED_ON);  
    }
    else {
      digitalWrite(ledPins[led], LED_OFF);                                            
    }
  }
}
