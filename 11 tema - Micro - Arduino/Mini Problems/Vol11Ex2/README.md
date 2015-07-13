#11 tema - Mikrovaldikliai - Arduino - Mini užduotėlės - 2 užd.

##Sąlyga

Sukurkite įrenginį, kuris LED lempučių eilės pagalba rodytų šviesos stiprumą - kuo stipresnė šviesa krinta į įrenginį, tuo daugiau lempučių dega.

##Patarimai

1. Užduočiai atlikti prisireiks šių elementų (iš įrankių paletės):
  1. 8 lempučių (galima ir daugiau, priklausomai kokio ilgio indikatorių norima sukurti)
  2. Šviesos rezistoriaus.  
  3. 9 rezistorių (8 lemputėms ir vienas šviesos rezistoriui).
2. Šviesos rezistorius grąžina analoginį signalą. Analoginis signalas nuskaitomas komandos `int value = analogRead(A0);`, kur A0 - analoginis kontaktas, iš kurio skaitome.
3. Norint nuskaityti analoginį signalą, įranginį riekia jungti į analoginį lizdą. Valdiklyje tokie lizdai pažymėti A0..A99.

##Eiga

- Sujunkite schemą kaip parodytą paveikslėlyje 
![schema] (https://github.com/niku-live/jpvs2015/tree/master/11%20tema%20-%2Micro%20-%20Arduino/Mini%20Problems/Vol11Ex2/circuit/vol11ex2_pict.jpg)
- Parašykite tokią programą:
```cpp
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
```
- Sukelkite programėlę į valdiklį.
