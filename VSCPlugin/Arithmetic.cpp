#include "Arithmetic.h"
#include <stdexcept>

using namespace Math;

Arithmetic::Arithmetic(){
}
Arithmetic::~Arithmetic(){
}

float Arithmetic::addition(float& val_1, float& val_2){
    return val_1 + val_2;
}

float Arithmetic::substraction(float& val_1, float& val_2){
    return val_1 - val_2;
}

float Arithmetic::multiplication(float& val_1, float& val_2){
    return val_1 * val_2;
}

float Arithmetic::division(float& val_1, float& val_2){
    if(val_2 == 0)
        throw new std::invalid_argument("denominator cannot be 0");
    return val_1 / val_2;
}
