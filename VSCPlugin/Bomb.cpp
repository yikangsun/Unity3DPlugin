#include "Bomb.h"


Bomb::Bomb()
{
    this->time = 0.0f;
}

Bomb::~Bomb()
{}

void Bomb::SetTime(float time)
{
    this->time = time;
}

float Bomb::GetTime()
{
    return time;
}


