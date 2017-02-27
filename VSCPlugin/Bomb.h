#ifndef BOMB_H
#define BOMB_H


class Bomb {
private: 
    float time;

public:
    Bomb();
    ~Bomb();

    void SetTime(float time);
    float GetTime();
};

#endif

