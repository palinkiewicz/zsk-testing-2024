// StaticLib.cpp : Defines the functions for the static library.
//

#include "pch.h"
#include "framework.h"

class SomeClass {
public:
    int gcd(int a, int b) {
        int res;

        if (a < b) {
            res = a;
        }
        else {
            res = b;
        }

        while (res > 1) {
            if (a % res == 0 && b % res == 0)
                break;
            res--;
        }
        return res;
    }
};
