// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


using System;
using static System.Console;

Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine());
Write("Введите число N: ");
int n = int.Parse(ReadLine());

int A = Ackerman(m,n);
Write($"A({m},{n}) = {A}");

int Ackerman(int n, int m)
{
    while (n>0)
    {
        if (m==0)
        {
            m = 1;
        }
        else 
        {
            m = Ackerman(n, m-1);
        }
        n = n - 1;
    }
    return m+1;
}