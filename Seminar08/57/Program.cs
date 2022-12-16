// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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
int[] RowArray = GetRowArray(array);
for (int i = 0; i<RowArray.Length; i++)
{
    Write($"{RowArray[i]}  ");
}
WriteLine();
SortArray(RowArray);
for (int i = 0; i<RowArray.Length; i++)
{
    Write($"{RowArray[i]}  ");
}
WriteLine();
ListArray(RowArray);





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

void ListArray(int [] inArray)
{ 
        int number = 1;
        int k = inArray[0];
        for (int i = 1; i < inArray.Length; i++)
        {
                if (inArray[i] == k)
                {
                    number ++;
                }
                else 
                {
                    WriteLine($"Число {k} встречается {number} раз(а)");
                    number = 1;
                    k = inArray[i];
                 }
        }
        WriteLine($"Число {k} встречается {number} раз(а)");
}

int[] GetRowArray(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)*arr.GetLength(1)];
    int index = 0;
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        for (int j = 0; j<arr.GetLength(1); j++)
        {
            result[index] = arr[i,j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i+1; j < inArray.Length; j++)
        {
            if(inArray[i]>inArray[j])
            {
                int k=inArray[i];
                inArray[i]=inArray[j];
                inArray[j]=k;
            }
        }
    }
}