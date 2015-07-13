const int pinButton = 2;

void setup() {
  pinMode(pinButton, INPUT_PULLUP);

  //inicijuojame klaviatūros biblioteką
  Keyboard.begin();
}


void loop() {
  if (!digitalRead(pinButton)) {

    //Sukuriame klaviatūros paspaudimo įvykį
    Keyboard.println(F("Parasyta su Arduino pagalba."));
    
    delay(300);
  }
}
