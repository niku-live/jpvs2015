#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <SPI.h>

#include "bitmap.h"

#define uint8  unsigned char
#define uint16 unsigned int

#define OLED_RESET 8
Adafruit_SSD1306 display(OLED_RESET);

#if (SSD1306_LCDHEIGHT != 64)
#error("Height incorrect, please fix Adafruit_SSD1306.h!");
#endif

#define PICTURE_GLCD_HEIGHT 64 
#define PICTURE_GLCD_WIDTH  128

void setup()   
{      
    display.begin(SSD1306_SWITCHCAPVCC, 0x3c);  // inicijuojame ekraną, 0x3c - ekrano adresas
    display.clearDisplay();
}

void loop()
{
    showLogo(0, 0); //nupaišome logotipą
}

void showLogo(uint8 x, uint8 y)
{
    display.clearDisplay(); 
    display.drawBitmap(x, y, logo_sunfounder, PICTURE_GLCD_WIDTH, PICTURE_GLCD_HEIGHT, 1);
    display.display();
}
