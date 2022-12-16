// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

using System;
using static System.Console;

Clear();
Write("Введите число A: ");
int A = int.Parse(ReadLine());
Write("Введите число B: ");
int B = int.Parse(ReadLine());

WriteLine(Exp(A,B));

int Exp(int a, int b)
{  
    int exp = A;
    if (b == 0)
    return 1;
    exp = exp * Exp(a, b-1);
    return exp;
}
