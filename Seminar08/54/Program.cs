// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int [,] arrayNew = SortArray(array);
PrintArray(arrayNew);




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

int[,] SortArray(int[,] inArray)
{
    int [,] result = inArray;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {  
            for (int k = j+1; k < result.GetLength(1); k++)
            {
                if(inArray[i,k]>inArray[i,j])
                {
                    int temp=result[i,j];
                    result[i,j]=result[i,k];
                    result[i,k]=temp;
                }
            }

        }
    }
    return result;
}