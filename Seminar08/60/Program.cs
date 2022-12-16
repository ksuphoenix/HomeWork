// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int x = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int y = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int z = int.Parse(ReadLine());

int[] array = DifferentNumbers(x,y,z);
for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}; ");
    }
WriteLine();

int [,,] array3D = Get3DArray(x, y, z, array);
PrintArray(array3D);
WriteLine();

int[] DifferentNumbers(int n, int m, int k)
{
    int size = n*m*k;
    int[] DifArray = new int [size];         
    for (int i=0; i<size; i++)
    {
        DifArray[i]= new Random().Next(10, 100);
        for (int j=0; j<i; j++)
        {
            if (DifArray[j]==DifArray[i])
            { DifArray[j]++;}
        }
    }
    return DifArray;
}

int[,,] Get3DArray(int m, int n, int l, int[] inArray)
{
    int[,,] result = new int[m, n, l];
    int a = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = inArray[a];
                a++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i,j,k]} [{i},{j},{k}]   ");
            }
            WriteLine();
        }
        WriteLine();
    }
}

