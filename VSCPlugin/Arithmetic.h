#ifndef MATH_ARITHMETIC_H
#define MATH_ARITHMETIC_H

namespace Math
{
    class Arithmetic
    {
    public:
        Arithmetic();//ctor

    protected:
        virtual ~Arithmetic();//dtor

    public:
        static float addition(float& val_1, float& val_2);
        static float substraction(float& val_1, float& val_2);
        static float multiplication(float& val_1, float& val_2);
        static float division(float& val_1, float& val_2);
    };
}

#endif