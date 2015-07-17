#include <ArduinoRobot.h>
#include <Wire.h>
#include <SPI.h>

#define trigPin TKD1
#define echoPin TKD3

void setup() 
{  
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);

  Robot.begin();
  Robot.beginTFT();
  Robot.beginSD();
  Robot.beginSpeaker();  
}

bool runningMode = false;

void loop() 
{  
  int key = Robot.keyboardRead();
  if (key == BUTTON_UP)
  {
    runningMode = !runningMode;
  }

  if (runningMode)
  {
    while (getDistance() < 20)
    {
      Robot.motorsStop();
      Robot.turn(90);    
    }
    Robot.motorsWrite(128, 128);
  }
}

int getDistance()
{
  int distance, duration;
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(1000);
  digitalWrite(trigPin, LOW);
  duration = pulseIn(echoPin, HIGH);  
  distance = (duration/2) / 29.1;
  delay(100);
  return distance; 
}

