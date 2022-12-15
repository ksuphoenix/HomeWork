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

int [,,] array = Get3DArray(x, y, z);
PrintArray(array);
WriteLine();

int[,,] Get3DArray(int m, int n, int l)
{
    int[,,] result = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = new Random().Next(10, 100);
                for (int i1 = 0; i1 <= i; i1++)
                {
                    for (int j1 = 0; j1 <= j; j1++)
                    {
                        for (int k1 = 0; k1 <= k; k1++)
                        {
                            result[i1, j1, k1] = new Random().Next(10, 100);
                            if (result[i1,j1,k1] == result[i, j, k])
                            {
                                result[i1, j1, k1] = new Random().Next(10, 100);
                            }
            }
        }
    }}}}
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
