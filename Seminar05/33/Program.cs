// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] NewArray(int index)
{
    int[] arr = new int [index];
    for  (int i =0; i<index; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}

int[] array = NewArray(4);
Console.WriteLine($"[{String.Join(",", array)}]");
int search = int.Parse(Console.ReadLine());

if (FindNumber(array,search) == true)
{
    Console.WriteLine($"YES");
}
else Console.WriteLine($"NO");

bool FindNumber(int[] array, int search)
{
    foreach (int el in array) 
    {
        if (el == search)
        return true;
    }
        return false;
    
}

