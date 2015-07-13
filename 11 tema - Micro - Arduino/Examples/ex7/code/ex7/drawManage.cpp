#include "drawManage.h"
#include "bitmap.h"

//常量定义
#define PICTURE_GLCD_HEIGHT 64 
#define PICTURE_GLCD_WIDTH  128 

#ifndef SSD1306_128_64//Always check Class files with Actual #define strings!
    #include <Adafruit_SSD1306.h>
#endif

DrawBase::DrawBase(Adafruit_SSD1306 *screen)
{
    _screen = screen;
}
DrawBase::~DrawBase()
{
}

void DrawBase::logo(uint8 x, uint8 y)
{
    _screen -> clearDisplay();   // clears the screen and buffer
    _screen -> drawBitmap(x, y,  logo_sunfounder, PICTURE_GLCD_WIDTH, PICTURE_GLCD_HEIGHT, 1);
    _screen -> display();
}

void DrawBase::testdrawline() 
{ 
    _screen -> clearDisplay();   // clears the screen and buffer 
    for (uint8 i = 0; i < _screen -> width(); i += 4) 
    {
        _screen -> drawLine(0, 0, i, _screen -> height()-1, WHITE);
        _screen -> display();
    }
    for (uint8 i = 0; i < _screen -> height(); i += 4) 
    {
        _screen -> drawLine(0, 0, _screen -> width()-1, i, WHITE);
        _screen -> display();
    }
    delay(250);
    
    _screen -> clearDisplay();
    for (int16_t i=0; i<_screen -> width(); i+=4) 
    {
        _screen -> drawLine(0, _screen -> height()-1, i, 0, WHITE);
        _screen -> display();
    }
    for (int16_t i=_screen -> height()-1; i>=0; i-=4) 
    {
        _screen -> drawLine(0, _screen -> height()-1, _screen -> width()-1, i, WHITE);
        _screen -> display();
    }
    delay(250);
    
   // _screen -> clearDisplay();
}

void DrawBase::testfillrect(void) 
{
    uint8 color = 1;
    _screen -> clearDisplay();
    for (uint8 i = 0; i < _screen -> height()/2; i += 3) 
    {
        // alternate colors
        _screen -> fillRect(i, i, _screen -> width()-i*2, _screen -> height()-i*2, color%2);
        _screen -> display();
        color++;
    }
}

void DrawBase::testscrolltext(void) 
{
    _screen -> clearDisplay();
    _screen -> setTextSize(2);
    _screen -> setTextColor(WHITE);
    _screen -> setCursor(10,0);
    _screen -> clearDisplay();
    _screen -> println("scroll");
    _screen -> display();
   
    _screen -> startscrollright(0x00, 0x0F);
    delay(2000);
    _screen -> stopscroll();
    delay(1000);
    _screen -> startscrollleft(0x00, 0x0F);
    delay(2000);
    _screen -> stopscroll();
    _screen -> display();
}
