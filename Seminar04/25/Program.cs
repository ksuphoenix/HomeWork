// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write ("Введите число A: ");
int A = int.Parse (Console.ReadLine ());
Console.Write ("Введите число B: ");
int B = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Число {A} в степени {B} равно {GetStepen (A,B)}");

int GetStepen (int A, int B) 
{
    if (B == 0)
    {
        int stp = 1;
        return stp;
    }
    else 
    {
        int st = 1;
        for (int i = 1; i <= B; i++)
        st = st*A;
        return st;
    }
}