// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

int k = (GetLowerRow(array));
Write($"Строка {k} с наименьшей суммой элементов");






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

int GetLowerRow(int[,] inArray)
{
    int[] temp = new int [inArray.GetLength(0)];
    int sum = 0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        sum = 0;
        for (int j=0; j<array.GetLength(1); j++)
        { 
            sum += array[i,j];
        }
        temp[i] = sum;
    }
    int count =0;
    int min = temp[0];
    for (int k=1; k<temp.Length; k++)
    {
        if (temp[k]<min)
        {
            min = temp[k];
            count = k;
        }
    }
    return count;
}