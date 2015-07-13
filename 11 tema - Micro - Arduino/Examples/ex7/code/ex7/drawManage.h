#ifndef __DRAWMANAGE_H__
#define __DRAWMANAGE_H__

#include <Arduino.h>

#ifndef SSD1306_128_64//Always check Class files with Actual #define strings!
  #include <Adafruit_SSD1306.h>
#endif

#define uint8  unsigned char
#define uint16 unsigned int

class DrawBase
{
    public:
        DrawBase(Adafruit_SSD1306 *screen);
        ~DrawBase();
        
        void logo(uint8 x, uint8 y);  //display logo
        void testdrawline();          //test drawline function in Adafruit_SSD1306 library
        void testfillrect(void);      //test fillrect function in Adafruit_SSD1306 library
        void testscrolltext(void);    //test scroll function in Adafruit_SSD1306 library  
        
        Adafruit_SSD1306 *_screen;
};

#endif

