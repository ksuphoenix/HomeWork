// Задать два числа и показать все натуральные числа между ними.

using System;
using static System.Console;

Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine());
Write("Введите число N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(m,n));

string PrintNumbers(int start, int end)
{
    if (start == end)
     return start.ToString();
    return (start + " " + PrintNumbers(start+1, end));
}

