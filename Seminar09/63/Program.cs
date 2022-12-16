using System;
using static System.Console;

Clear();
Write("Введите число N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(n));

string PrintNumbers(int end)
{
    if (end==1)
     return "1";
    return (PrintNumbers(end - 1) + ' ' + end.ToString());
}
