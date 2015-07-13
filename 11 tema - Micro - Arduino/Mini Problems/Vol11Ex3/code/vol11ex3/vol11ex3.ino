#include<LiquidCrystal.h>  

int duration = 500;

LiquidCrystal lcd(4, 6, 10, 11, 12, 13); 
const int TrigPin = 2;
const int EchoPin = 3;
const int buzzer = 5;
float cm,currentDis,lastDis,intervalDis;

void setup()
{
   Serial.begin(9600); 
   pinMode(TrigPin,OUTPUT);
   pinMode(EchoPin,INPUT);
   pinMode(buzzer,OUTPUT);
   lcd.begin(16,2);  
   lcd.print("Reversing radar");  
   delay(2000);  
   lcd.clear();
}

void loop()
{
  digitalWrite(TrigPin,LOW);
  delayMicroseconds(2);
  digitalWrite(TrigPin,HIGH);
  delayMicroseconds(10);
  digitalWrite(TrigPin,LOW);
	
  cm = pulseIn(EchoPin,HIGH)/58.0;  
  cm = (int(cm * 100.0))/100.0;
  if(cm < 0)
  {
    cm = 0;
  }
  lcd.setCursor(0,0);  
  lcd.print("Distance:");
  lcd.setCursor(0,1);  
  lcd.print("                ");
  lcd.setCursor(3,1);  
  lcd.print(cm);  
  lcd.setCursor(9,1);
  lcd.print("cm");
  delay(100);
  intervalDis = lastDis - cm;
  if(cm < 15 & cm >= 5)
  {
    if(duration < 200)
    {
      duration = 200;
    }
    duration =duration - 100;
    Serial.print("duration");
    Serial.println(duration);
    digitalWrite(buzzer, HIGH);
    delay(duration);
    digitalWrite(buzzer, LOW);
  }
  else if(cm < 5 & cm >= 0)
  {
    digitalWrite(buzzer, HIGH);
  }
  else
  {
    delay(1000);
    digitalWrite(buzzer, HIGH);
    delay(100);
    digitalWrite(buzzer, LOW);
  }
  lastDis = cm;
}
