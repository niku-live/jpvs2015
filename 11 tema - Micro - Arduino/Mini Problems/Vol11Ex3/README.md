#11 tema - Mikrovaldikliai - Arduino - Mini užduotėlės - 3 užd.

##Sąlyga

Sukurkite įrenginį, imituojantį automobiliuose įmontuotus atstumo sentorius - LCD ekranėlyje turėtų būti rodomas atstumas iki artimiausios kliūties ir turėtų būti garsinis signalas, kuris stiprėtų atstumui mažėjant ir silpnėtų atstumui didėjant.

##Patarimai

1. Užduočiai atlikti prisireiks šių elementų (iš įrankių paletės):
  1. LCD ekranėlio (tokio, koks buvo naudotas per paskaitą).
  2. Potenciometro.
  3. SR-04 ultragarso sensoriaus.
  4. Garsiakalbio
2. SR-04 sensorius veikia aido principu - išsiunčiamas ultragarso signalas ir laukiama aido, sulaukus suskaičiuojama kiek praėjo laiko ir pagal tai apskaičiuojamas atstumas. Naudojamasi tokiu principu:
  1. Į TRIG kontaktą paduodama įtampa ir palaikoma apie 10 mikrosekundžių.
  2. Laukiama, kol kontakte ECHO atsiras įtampa.
3. Laukti kol kontakte atsiras įtampa galima pasinaudojus komanda `int time = pulseIn(EchoPin, HIGH);`, kur **EchoPin** - numeris valdiklio kontakto, prie kurio prijungtas ECHO kontaktas. Funkcija grąžins praėjusį laiką, kol sulaukta atsako.

##Eiga

- Sujunkite schemą kaip parodytą paveikslėlyje 
![schema](https://raw.githubusercontent.com/niku-live/jpvs2015/master/11%20tema%20-%20Micro%20-%20Arduino/Mini%20Problems/Vol11Ex3/circuit/Vol11Ex3_pict.jpg)
- Parašykite tokią programą:
```cpp
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
```
- Sukelkite programėlę į valdiklį.
