#include <LiquidCrystal_I2C.h>
// SDA -> A4 és SCL -> A5 legyen!!
LiquidCrystal_I2C lcd(0x27,16,2);
int echoPin=2;
int trigPin=3;
long duration; 
int distance_cm;
int distance_inch;
byte buzzer =7;
int zold = 9;
int piros = 10;

void setup() {
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
  lcd.init();
  lcd.backlight();
  pinMode(buzzer, OUTPUT);
  pinMode(zold,OUTPUT);
  pinMode(piros,OUTPUT);
}

void loop() {
 digitalWrite(trigPin, LOW);// Clears the trigPin condition
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);//trigPin HIGH (ACTIVE) for 10 microseconds
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  duration = pulseIn(echoPin, HIGH);// Reads the echoPin, returns the sound wave
  distance_cm = duration * 0.034 / 2; // Speed of sound wave divided by 2 (go and back)
  distance_inch = duration * 0.0133 / 2; // Speed of sound wave divided by 2 (go and back)
  lcd.setCursor(0, 0);
  lcd.print("Distance: ");
  lcd.print(distance_cm);
  lcd.print(" cm  ");
  lcd.setCursor(0, 1);
  lcd.print("Distance: ");
  lcd.print(distance_inch);
  lcd.print(" inch");
  //delay(100);

if(distance_cm<30 && distance_cm>=20)
{
tone(buzzer,900);
delay(100);
noTone(buzzer);
delay(500);
}

if(distance_cm<20 && distance_cm>=10)
{
tone(buzzer,900);
delay(100);
noTone(buzzer);
delay(250);
digitalWrite(zold,HIGH);
}

if(distance_cm<10 && distance_cm>=4)
{
tone(buzzer,900);
delay(100);
noTone(buzzer);
delay(100);
digitalWrite(zold,HIGH);
}

if (distance_cm<4 && distance_cm>0){
tone(buzzer,900);
delay(100);
digitalWrite(piros,HIGH);
digitalWrite(zold,LOW);
}
if(distance_cm>=30)
{
digitalWrite(piros,LOW);
digitalWrite(zold,LOW);
noTone(buzzer);
}

}
