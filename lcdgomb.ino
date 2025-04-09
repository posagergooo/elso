#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27,16,2);
byte e[8] = {
  B00010,
  B00100,
  B01110,
  B10001,
  B11111,
  B10000,
  B01110,
  B00000
};
 
byte o[8] = {
  B01010,
  B01010,
  B01110,
  B10001,
  B10001,
  B10001,
  B01110,
  B00000
};
byte pinLED=3;
byte pinGomb1=0;
byte pinGomb2=1;
byte allapot;
bool be1, oldbe1;
bool be2, oldbe2;
int i;
void setup() {
  // put your setup code here, to run once:
pinMode(pinGomb1,INPUT);
pinMode(pinGomb2,INPUT);
pinMode(pinLED,OUTPUT);
lcd.init(); //inicializálás
lcd.backlight(); //háttérvilágítás
lcd.createChar(0,e);
lcd.createChar(1,o);
lcd.setCursor(0,0);
lcd.print("F");
lcd.write((byte)0);
lcd.print("nyer");
lcd.write((byte)1);
lcd.print(":");
delay(4000);
}

void loop() {
  // put your main code here, to run repeatedly:
be1=digitalRead(pinGomb1);
if(be1==0 && be1!=oldbe1)
{
  if(allapot<250)
{
  allapot=allapot+25;
}
  analogWrite(pinLED,allapot);
  delay(50);
}
be2=digitalRead(pinGomb2);
if(be2==0 &&be2!=oldbe2)
{
  if(allapot<255)
{
  allapot=allapot-25;
}
  analogWrite(pinLED,allapot);
  delay(50);
}
lcd.setCursor(10,0);
lcd.print(allapot/25);
lcd.print(" ");
oldbe1=be1;
oldbe2=be2;
}
