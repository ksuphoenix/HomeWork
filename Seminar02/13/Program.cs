// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Console.Clear();

Console.Write($"Введите число: ");
int num = int.Parse(Console.ReadLine());

int i = 100;
int k = 1;
int result = 0; 

if (num<i)
{
    Console.WriteLine($"Нет третьего числа");
}
else 
{
    while (i<num) 
    {
        result = (num/k)%10;
        i = i*10; 
        k=k*10;
    }
}

Console.WriteLine(result);