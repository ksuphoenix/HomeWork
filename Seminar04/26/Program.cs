// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.Write ("Введите число: ");
int number = int.Parse (Console.ReadLine ());
Console.WriteLine ($"В числе {number} - {GetNumber (number)} цифр");

int GetNumber (int number) 
{
    int k = 1;
    int i = 0;
    while (number/k>0) 
    {
        i++; 
        k=k*10;
        
    }
    return i;
}
