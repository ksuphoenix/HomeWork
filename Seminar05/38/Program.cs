// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.Write($"Введите длину массива: ");
int N = int.Parse(Console.ReadLine());
Console.Write($"Введите min: ");
int min = int.Parse(Console.ReadLine());
Console.Write($"Введите max: ");
int max = int.Parse(Console.ReadLine());
int[] arr = NewArray(N, min, max);
Console.WriteLine($"[{String.Join(",", arr)}]");
Console.WriteLine($"Разница между max и min элементами -> {MinMaxDiv(arr)}");


int[] NewArray(int index, int minValue, int maxValue)
{
    int[] arr = new int [index];
    for  (int i =0; i<index; i++)
    {
        arr[i] = new Random().Next(minValue,maxValue);
    }
    return arr;
}

int MinMaxDiv(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i =1; i<array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
        if (array[i]<min)
        {
            min = array[i];
        }
    }
    int div = max - min;
    return div;
}