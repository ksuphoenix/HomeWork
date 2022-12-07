// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Console.WriteLine($"[{String.Join(",", NewArray(8))}]");

int[] NewArray(int index)
{
    int[] arr = new int [index];
    for  (int i =0; i<index; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
    return arr;
}
