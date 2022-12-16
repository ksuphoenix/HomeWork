// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int [,] array = GetArray(rows,columns,1,10);
PrintArray(array);
WriteLine();

ChangeArray(array);
PrintArray(array);



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

void ChangeArray(int [,] inArray)
{
    if (inArray.GetLength(0) == inArray.GetLength(1))
    {
        for (int i=0; i<array.GetLength(0); i++)
        {
            for (int j=i; j<array.GetLength(1); j++)
            { 
                int temp = array[j,i];
                array[j,i] = array[i,j];
                array[i,j] = temp;
            }
        }
    }
    else
    {
        WriteLine("Повернуть массив нельзя");
    }
}