// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

using System;
using static System.Console;

Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine());

WriteLine($"{m} -> {SumNumber(m)}");

int SumNumber(int number)
{
    if (number==0)
     return 0;
     int sum = number % 10 + SumNumber(number/10);
    return sum;
}