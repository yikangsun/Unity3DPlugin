#ifndef PRINTER_H
#define PRINTER_H

namespace Printer
{
	const char*  PrintHello(){
		return "Hello nuTonomy";
	}

	int PrintANumber(){
		return 666;
	}

	int AddTwoIntegers(int a, int b) {
		return a + b;
	}

	float AddTwoFloats(float a, float b) {
		return a + b;
	}
}

#endif