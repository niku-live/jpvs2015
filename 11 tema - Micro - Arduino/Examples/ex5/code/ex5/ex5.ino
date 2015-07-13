//importuojame LCD biblioteką
#include <LiquidCrystal.h>

/**********************************************************/
char array1[]=" NOVI HOMINES             ";  //the string to print on the LCD
char array2[]=" JPVS 2015                ";  //the string to print on the LCD
int tim = 250;  

// inicijuojame LCD biblioteką nurodydami valdymo kontaktus.
LiquidCrystal lcd(4, 6, 10, 11, 12, 13);

/*********************************************************/
void setup()
{
  lcd.begin(16, 2);  // LCD stulpelių ir eilučių skaičius
}

/*********************************************************/
void loop() 
{
    lcd.setCursor(15,0);  // pakeičiame kursoriaus vietą į 15 stulpelį 0 eilutę (numeruojama nuo 0)
    for (int positionCounter1 = 0; positionCounter1 < 26; positionCounter1++)
    {
      lcd.scrollDisplayLeft();  //pastumiame anksčiau išspausdintą tektą į kairę.
      lcd.print(array1[positionCounter1]);  // Išspausdiname raidę.
      delay(tim); 
    }
    lcd.clear();  
    lcd.setCursor(15,1);  
    for (int positionCounter = 0; positionCounter < 26; positionCounter++)
    {
      lcd.scrollDisplayLeft();
      lcd.print(array2[positionCounter]); 
      delay(tim); 
    }
    lcd.clear();  
}
/************************************************************/

