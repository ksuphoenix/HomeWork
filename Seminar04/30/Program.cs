// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


Console.WriteLine($"[{String.Join(",", NewArray(8))}]");

int[] NewArray(int index)
{
    int[] arr = new int [index];
    for  (int i =0; i<index; i++)
    {
        arr[i] = new Random().Next(2);
    }
    return arr;
}


//new Random().Next(2);