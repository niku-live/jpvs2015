#define player1 2  //pirmo zaidejo mygtuko kontaktas
#define player2 3  //antro zaidejo mygtuko kontaktas
#define player3 4  //trecio zaidejo mygtuko kontaktas
#define host    9  //zaidimo vedejo mygtuko kontaktas
#define buzzerPin 5  //garsiakalbio kontaktas    
#define redLED 6
#define yellowLED 7
#define blueLED 8
#define hostLED 10

#define uint8 unsigned char
#define uint16 unsigned int

uint8 flag = 0;
uint8 p1State, p2State, p3State, hState = 0;

void setup()
{
  pinMode(buzzerPin, OUTPUT);     
  pinMode(redLED, OUTPUT);
  pinMode(yellowLED, OUTPUT);     
  pinMode(blueLED, OUTPUT); 
  pinMode(hostLED, OUTPUT);

  pinMode(player1, INPUT_PULLUP);
  pinMode(player2, INPUT_PULLUP);
  pinMode(player3, INPUT_PULLUP);    
  pinMode(host, INPUT_PULLUP);
  //pradzioje isjungiam visas lemputes
  digitalWrite(redLED, LOW);
  digitalWrite(yellowLED, LOW);  
  digitalWrite(blueLED, LOW); 
  digitalWrite(hostLED, LOW);
}
void loop()
{
  digitalWrite(redLED, LOW);
  digitalWrite(yellowLED, LOW);  
  digitalWrite(blueLED, LOW);  
  digitalWrite(hostLED, LOW);
  //nuskaitome vedejo mygtuko busena
  hState = digitalRead(host);  
  if(hState == 0)
  {
    flag = 1;
    digitalWrite(hostLED, HIGH);
    delay(200);  
  }
  if(1 == flag)
  {
    //nuskaitome zaideju mygtuku busenas
    p1State = digitalRead(player1);  
    p2State = digitalRead(player2);
    p3State = digitalRead(player3);
    //jei pirmasis paspaude 1 zaidejas
    if(p1State == 0)
    {
      flag = 0;
      digitalWrite(hostLED, LOW);
      Alarm(); 
      digitalWrite(redLED,HIGH); 
      digitalWrite(yellowLED,LOW); 
      digitalWrite(blueLED,LOW); 
      while(digitalRead(host)); //nereaguojam į kitus paspaudimus, laukiama, kol vedejas paspaus savo mygtuka
    }
    if(p2State == 0)
    {
      flag = 0;
      digitalWrite(hostLED, LOW);
      Alarm();
      digitalWrite(redLED,LOW);
      digitalWrite(yellowLED,HIGH); 
      digitalWrite(blueLED,LOW); 
      while(digitalRead(host));
    }
    if(p3State == 0)
    {
      flag = 0;
      digitalWrite(hostLED, LOW);
      Alarm();
      digitalWrite(redLED,LOW);
      digitalWrite(yellowLED,LOW); 
      digitalWrite(blueLED,HIGH); 
      while(digitalRead(host));
    }
  }
}

//garsinis signalas
void Alarm()         
{
  for(int i = 0; i < 100; i++){
  digitalWrite(buzzerPin,HIGH);
  delay(2);
  digitalWrite(buzzerPin,LOW); 
  delay(2);
  }
}
