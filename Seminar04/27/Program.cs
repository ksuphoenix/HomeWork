// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write ("Введите число: ");
int N = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Сумма цифр в числе {N} равна {GetNumberSum (N)}");

int GetNumberSum (int N) 
{
    int sum = 0;
    for (int i = 1; i <= N; i = i*10)
        sum += (N/i)%10;
    return sum;
}