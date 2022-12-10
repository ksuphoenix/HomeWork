// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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



int[] InvertArray (int[] array) 
{
    for (int i=0; i<array.Length; i++) 
    {
        array[i] *= -1;
    }
    return array;
}
Console.WriteLine($"[{String.Join(",", InvertArray(array))}]");