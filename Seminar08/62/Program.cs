// Напишите программу, которая заполнит спирально массив 4 на 4.

using System;
using static System.Console;
Write("Введите число n:");
int n = int.Parse(ReadLine());
int[,] array = SpiralMatrix(n);
PrintArray(array);


int[,] SpiralMatrix(int n) 
{
    int[,] result = new int[n, n];

    int position = 1;
    int count = n;
    int value = -n;
    int sum = -1;
    do {
        value = -1 * value / n;
        for (int i = 0; i<count; i++)
        {
            sum += value;
            result[sum/n,sum%n] = position;
            position++;
        }
        value *= n;
        count--;
        for (int i = 0; i<count; i++)
        {
            sum += value;
            result[sum/n,sum%n] = position;
            position++;
        }
    } while (count > 0);

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]}   ");
        }
        WriteLine();
    }
}
