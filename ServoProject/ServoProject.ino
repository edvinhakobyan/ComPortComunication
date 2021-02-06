

#include <LiquidCrystal_I2C.h>


LiquidCrystal_I2C lcd(0x27, 16, 2);

void setup()
{
	Serial.begin(115200);
	lcd.init();
	lcd.backlight();
}


String s;
void loop()
{
	//if (Serial.available() > 0)
	//{
	//	lcd.clear();
	//	String r = Serial.readString();

	//	lcd.print(r);
	//}

	long x = random(-250, 250);
	long y = random(-250, 250);

	s += x;
	s += " ";
	s += y;


	Serial.println(s);
	s = "";

	//delay(200);
}





//long GetInt(int i, byte bytes[])
//{
//	i *= 4;
//	return (long)bytes[i + 0] << 24 | bytes[i + 1] << 16 | bytes[i + 2] << 8 | bytes[i + 3] << 0;
//}
//
//void AddInByteArray(long a, long b)
//{
//	bufer[0] = (a & 0x000000ff);
//	bufer[1] = (a & 0x0000ff00) >> 8;
//	bufer[2] = (a & 0x00ff0000) >> 16;
//	bufer[3] = (a & 0xff000000) >> 24;
//
//	bufer[4] = (b & 0x000000ff);
//	bufer[5] = (b & 0x0000ff00) >> 8;
//	bufer[6] = (b & 0x00ff0000) >> 16;
//	bufer[7] = (b & 0xff000000) >> 24;
//}
