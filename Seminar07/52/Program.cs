// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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

double[] average = AverageColumns(array);
for (int i=0;  i<average.Length; i++)
{
    Write($"{average[i]:f2}  ");
}



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

double[] AverageColumns(int [,] array)
{
    double[] AvColumns = new double [array.GetLength(1)];
    int size = array.GetLength(0);
    for (int j=0; j<array.GetLength(1); j++)
    {
        double average = 0;
        for (int i=0; i<array.GetLength(0); i++)
        {
            average += array[i,j];    
        }
        average = average/size;
        AvColumns[j] = average;
    }
    return AvColumns;
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
