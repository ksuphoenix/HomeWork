//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a<1 ||a>7)
{
    Console.WriteLine($"Введен неправильный номер");
}
if (a==1)
{
    Console.WriteLine($"{a}->Понедельник");
}
if (a==2)
{
    Console.WriteLine($"{a}->Вторник");
}
if (a==3)
{
    Console.WriteLine($"{a}->Среда");
}
if (a==4)
{
    Console.WriteLine($"{a}->Четверг");
}
if (a==5)
{
    Console.WriteLine($"{a}->Пятница");
}
if (a==6)
{
    Console.WriteLine($"{a}->Суббота");
}
if (a==7)
{
    Console.WriteLine($"{a}->Воскресенье");
}
