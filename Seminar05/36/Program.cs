// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введите длину массива: ");
int N = int.Parse(Console.ReadLine());
Console.Write($"Введите min: ");
int min = int.Parse(Console.ReadLine());
Console.Write($"Введите max: ");
int max = int.Parse(Console.ReadLine());
int[] arr = NewArray(N, min, max);
Console.WriteLine($"[{String.Join(",", arr)}]");
Console.WriteLine($"Сумма нечетных элементов в массиве -> {SumNechet(arr)}");

int SumNechet(int[] arr)
{
    int sum = 0;
    for (int i=1; i<arr.Length; i=i+2)
    {   
        sum +=arr[i];
    }
    return sum;
}

int[] NewArray(int index, int minValue, int maxValue)
{
    int[] arr = new int [index];
    for  (int i =0; i<index; i++)
    {
        arr[i] = new Random().Next(minValue,maxValue);
    }
    return arr;
}