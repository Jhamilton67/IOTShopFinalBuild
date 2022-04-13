/*
 Name:		IotShopSensorCode.ino
 Created:	3/15/2022 6:20:09 PM
 Author:	user
*/

//Defining Pin Numbers & variables for Ultrasonic Range Sensor  
const int Tringpin = 8;
const int Echopin = 7;
long duration;
int distance;

void UltraSonicRangeSensor()
{
	pinMode(Tringpin, OUTPUT);
	pinMode(Echopin, INPUT);
	Serial.begin(9600);
}

// the setup function runs once when you press reset or power the board
void setup() {

}

// the loop function runs over and over again until power down or reset
void loop() {
  
}
