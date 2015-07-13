#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <SPI.h>

#include "drawManage.h"

#define uint8  unsigned char
#define uint16 unsigned int

#define OLED_RESET 8
Adafruit_SSD1306 display(OLED_RESET);
DrawBase drawBase(&display);

#if (SSD1306_LCDHEIGHT != 64)
#error("Height incorrect, please fix Adafruit_SSD1306.h!");
#endif

void setup()   
{  
    display.begin(SSD1306_SWITCHCAPVCC, 0x3c);
    display.clearDisplay();
    drawBase.logo(0, 0);
    delay(2000);
    display.clearDisplay();
}

void loop()
{
    // nupiešti linijas
    drawBase.testdrawline();
    delay(2000);

    // nupiešti stačiakampius
    drawBase.testfillrect();
    delay(2000);
    
    // judantis tekstas
    drawBase.testscrolltext();
    delay(2000);
}

