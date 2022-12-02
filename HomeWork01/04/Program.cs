// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
int a = int.Parse (Console.ReadLine());
int b = int.Parse (Console.ReadLine());
int c = int.Parse (Console.ReadLine());
int max;

if (a>b && a>c)
{ 
    max = a;
} 
else
{
    if (b>c)
    {
        max = b;
    }
    else
    max = c;
}
Console.WriteLine($"max = {max}");