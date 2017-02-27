
#include "Api.h"
#include "../Arithmetic.h"
#include "../Printer.h"

using namespace Math;

/*
 * call class' static functions
 */

EXPORT_API float addition(float val_1, float val_2)
{
    return Arithmetic::addition(val_1, val_2);
}

EXPORT_API float substraction(float val_1, float val_2)
{
    return Arithmetic::substraction(val_1, val_2);
}

EXPORT_API float multiplication(float val_1, float val_2)
{
    return Arithmetic::multiplication(val_1, val_2);
}

EXPORT_API float division(float val_1, float val_2)
{
    return Arithmetic::division(val_1, val_2);
}


/*
 * call namespace's global functions
 */

const EXPORT_API char*  PrintHello()
{
    return Printer::PrintHello();
}

int EXPORT_API PrintANumber()
{
    return Printer::PrintANumber();
}

int EXPORT_API AddTwoIntegers(int a, int b) 
{
    return Printer::AddTwoIntegers(a,b);
}

float EXPORT_API AddTwoFloats(float a, float b) 
{
    return Printer::AddTwoFloats(a, b);
}
