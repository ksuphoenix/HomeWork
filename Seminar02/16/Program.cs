// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear();

int num1 = int.Parse (Console.ReadLine());
int num2 = int.Parse (Console.ReadLine());
if (num1*num1 == num2)
{
    Console.WriteLine($"Число {num2} квадрат числа {num1}");
    return;
}
if (num2*num2 == num1)
{
    Console.WriteLine($"Число {num1} квадрат числа {num2}");
}
else
Console.WriteLine($"Число {num2} не квадрат числа {num1}");
