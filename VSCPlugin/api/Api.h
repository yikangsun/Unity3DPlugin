#ifndef API_H
#define API_H

#if _MSC_VER // this is defined when compiling with Visual Studio
#define EXPORT_API __declspec(dllexport) // Visual Studio needs annotating exported functions with this
#else
#define EXPORT_API // XCode does not need annotating exported functions, so define is empty
#endif

#include "../Bomb.h"

// Link following functions C-style (required for unity plugins)
extern "C"
{
    // invoke class static functions
    EXPORT_API float addition(float val_1, float val_2);
    EXPORT_API float substraction(float val_1, float val_2);
    EXPORT_API float multiplication(float val_1, float val_2);
    EXPORT_API float division(float val_1, float val_2);

    // invoke namespace global functions
    EXPORT_API const char* PrintHello();
    EXPORT_API int PrintANumber();
    EXPORT_API int AddTwoIntegers(int a, int b);
    EXPORT_API float AddTwoFloats(float a, float b);

    // invoke class 
    EXPORT_API Bomb* Bomb_Create() { return new Bomb(); }
    EXPORT_API void Bomb_SetTime(Bomb* pBomb, float time) { return pBomb->SetTime(time); }
    EXPORT_API float Bomb_GetTime(Bomb* pBomb) {return pBomb->GetTime(); }
    EXPORT_API void Bomb_Delete(Bomb* pBomb) { delete pBomb; }
} 
// end of export C block


#endif