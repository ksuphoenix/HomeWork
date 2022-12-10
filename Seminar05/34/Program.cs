// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write($"Введите длину массива: ");
int N = int.Parse(Console.ReadLine());
int[] arr = NewArray(N);
Console.WriteLine($"[{String.Join(",", arr)}]");
Console.WriteLine($"Четных чисел в массиве -> {Chetnye(arr)}");

int Chetnye(int[] arr)
{
    int count = 0;
    for (int i=0; i< arr.Length; i++)
    {   
        if (arr[i]%2==0)
        {
            count++;
        }
    }
    return count;
}

int[] NewArray(int index)
{
    int[] arr = new int [index];
    for  (int i =0; i<index; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}
