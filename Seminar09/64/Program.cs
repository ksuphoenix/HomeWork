// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// M = 5; N = 3 -> "5, 4, 3"
// M = 8; N = 4. -> "8, 7, 6, 5, 4"

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
    return (start + " " + PrintNumbers(start-1, end));
}

