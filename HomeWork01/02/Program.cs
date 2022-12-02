// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max;
if (a>b) 
{
    max = a;
}
else 
max = b;
Console.WriteLine($"max = {max}");