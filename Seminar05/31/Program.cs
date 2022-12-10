// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] NewArray(int index)
{
    int[] arr = new int [index];
    for  (int i =0; i<index; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}

int[] array = NewArray(12);
Console.WriteLine($"[{String.Join(",", array)}]");

int PlusSum = 0;
int MinusSum = 0;
foreach (int el in array)   //  проходит весь массив и проверяет каждый элемент
{
    PlusSum += el > 0 ? el : 0; // конструкция проверки знака элемента
    MinusSum += el < 0 ? el : 0; 
}
 Console.WriteLine($"MinusSum = {MinusSum}, PlusSum = {PlusSum}");


