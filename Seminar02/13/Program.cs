// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Console.Clear();

Console.Write($"Введите число: ");
int num = int.Parse(Console.ReadLine());

int i = 100;
int k = 1;
 

if (num<i)
{
    Console.WriteLine($"Нет третьего числа");
}
else 
{
    i = i*10;
    k=k*10;
    while (num<i) 
    {
    if (((i*10)>num) && (num>(i-1)))
    {
        Console.WriteLine($"{(num/k)%10}");
    }
    
    i = i*10;
    k=k*10;
    }
}