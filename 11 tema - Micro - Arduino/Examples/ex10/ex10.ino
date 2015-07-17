#include <ArduinoRobot.h>
#include <Wire.h>
#include <SPI.h>

void setup() 
{  
  Robot.begin();
  Robot.beginTFT();
  Robot.beginSD();
  Robot.beginSpeaker();

  Robot.drawBMP("lf.bmp", 0, 0);
  Robot.playFile("chase.sqm");

  Robot.waitContinue();

  Robot.lineFollowConfig(11, 7, 60, 5);
  Robot.setMode(MODE_LINE_FOLLOW);
}

void loop() 
{
}
