// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write ("Введите число: ");
int N = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Произведение чисел от 1 до {N} равно {GetMultiple (N)}");

int GetMultiple (int N) 
{
    int multiple = 1;
    for (int i = 1; i <= N; i++)
        multiple *= i;
    return multiple;
}