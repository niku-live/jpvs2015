#include <ArduinoRobot.h>
#include <Wire.h>
#include <SPI.h>

/* Sikio zingsniai:
  S: sutoti
  L: i kaire
  R: i desine
  F: pirmyn
  B: atgal
*/
char danceScript[] = "S4L1R1S2F1B1S1\0";

int currentScript = 0; // what step are we at
int currentSong = 0; // keep track of the current song
static const int SONGS_COUNT = 3; // number of songs

char musics[][11] = 
{
  "melody.sqm",
  "menu.sqm",
  "chase.sqm",
};

long waitFrom;
long waitTime = 0;

void setup() 
{  
  Robot.begin();
  Robot.beginSpeaker();
  Robot.beginSD();
  Robot.beginTFT();

  Robot.displayLogos();

  delay(3000);

  setInterface();
  play(0);

  resetWait();
}

void loop() 
{ 
  int key = Robot.keyboardRead();  
  switch (key) 
  {
    case BUTTON_UP:
    case BUTTON_LEFT:
      play(-1);  //groti ankstesne daina
      break;
    case BUTTON_DOWN:
    case BUTTON_RIGHT:
      play(1);  //groti sekancia daina
      break;
  }
  runScript();
}

void runScript() 
{
  if (!waiting()) 
  {     
    parseCommand(danceScript[currentScript], danceScript[currentScript + 1]);
    currentScript += 2;
    if (danceScript[currentScript] == '\0') //pasiekeme sokio pabaiga
    {
      currentScript = 0;
    }
  }
}

boolean waiting() 
{
  if (millis() - waitFrom >= waitTime)
  {
    return false;
  }
  else
  {
    return true;
  }
}

void wait(long t) 
{
  resetWait();
  waitTime = t;
}

void resetWait()
{
  waitFrom = millis();
}

void parseCommand(char dir, char duration) 
{  
  switch (dir) 
  {
    case 'L':
      Robot.motorsWrite(-255, 255);
      break;
    case 'R':
      Robot.motorsWrite(255, -255);
      break;
    case 'F':
      Robot.motorsWrite(255, 255);
      break;
    case 'B':
      Robot.motorsWrite(-255, -255);
      break;
    case 'S':
      Robot.motorsStop();
      break;
  }  
  wait(500 * (duration - '0'));
}

void setInterface() 
{
  Robot.clearScreen();
  Robot.stroke(0, 0, 0);
  Robot.text(musics[0], 0, 0);
}

void select(int seq, boolean onOff) 
{
  if (onOff)
  {
    Robot.stroke(0, 0, 0);
    Robot.text(musics[seq], 0, 0);
  } 
  else 
  {
    Robot.stroke(255, 255, 255);
    Robot.text(musics[seq], 0, 0);
  }
}

void play(int seq) 
{
  select(currentSong, false);
  if (currentSong <= 0 && seq == -1) 
  { 
    currentSong = SONGS_COUNT - 1;
  } 
  else if (currentSong >= SONGS_COUNT - 1 && seq == 1) 
  { 
    currentSong = 0;
  }
  else 
  {
    currentSong += seq;
  }
  Robot.stopPlayFile();
  Robot.playFile(musics[currentSong]);
  select(currentSong, true);
}
