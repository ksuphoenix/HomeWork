// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// a[0,0] a[0,1] a[0,2]         b[0,0] b[0,1] b[0,2]         c[0,0] c[0,1] c[0,2]
// a[1,0] a[1,1] a[1,2]   X     b[1,0] b[1,1] b[1,2]    =    c[1,0] c[1,1] c[1,2]
// a[2,0] a[2,1] a[2,2]         b[2,0] b[2,1] b[2,2]         c[2,0] c[2,1] c[2,2]

// c[i,j] = a[i,0] * b[0,j] + a[i,1] * b[1,j] + a[i,2] * b[2,j]



using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows1=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns1=int.Parse(ReadLine());

int [,] array1 = GetArray(rows1,columns1,1,10);
PrintArray(array1);
WriteLine();

Write("Введите количество строк массива: ");
int rows2=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns2=int.Parse(ReadLine());

int [,] array2 = GetArray(rows2,columns2,1,10);
PrintArray(array2);
WriteLine();

if (columns1 == rows2)
{
    int[,] MultiMatrix = MatrixMultiplication(array1, array2);
    WriteLine("Результирующая матрица: ");
    PrintArray(MultiMatrix);
}
else 
WriteLine($"Нельзя перемножить");



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

int[,] MatrixMultiplication(int[,] array1, int[,] array2)                 // array1[m,n] . array2[n,k]
{
    int m = array1.GetLength(0);
    int n = array1.GetLength(1);
    int l = array2.GetLength(0);
    int k = array2.GetLength(1);
    int [,] result = new int [m, k];                                       // result[m,k]                  
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {  
            result[i,j] = 0;
            for (int r = 0; r < n; r++)
            {
               result[i,j]+= (array1[i,r]*array2[r,j]);
            }
        }
    }
    return result;
}