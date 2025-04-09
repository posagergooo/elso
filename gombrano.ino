byte pinLED=11, i;
bool allapot;
int pinGomb=8,Gomb,oldGomb, ido=20;
void setup() {
  pinMode(pinGomb,INPUT);
  pinMode(pinLED, OUTPUT);
}

void loop() {
 Gomb=digitalRead(pinGomb);
 if(Gomb==0 && Gomb!=oldGomb){
  {
    if(allapot==0)
  {
  for(i=0;i<255;i++)
  {
  analogWrite(pinLED,i);
   delay(ido);
   }
   }

else
{
  for(i=255;i>0;i--)
  {
  analogWrite(pinLED,i);
   delay(ido);}
  }
  }
 }
 allapot=!allapot;
 oldGomb=Gomb;
 }
