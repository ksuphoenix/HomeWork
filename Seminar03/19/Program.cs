// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write($"N=");
int N = int.Parse(Console.ReadLine());

if (N/10000 == N%10 && (N/1000)%10 == (N/10)%10)
{
    Console.WriteLine($"Палиндром");
}
else 
Console.WriteLine($"Не палиндром");




