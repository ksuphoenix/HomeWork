// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Clear();

int num1 = int.Parse (Console.ReadLine());
int num2 = int.Parse (Console.ReadLine());
if (num1%num2 == 0)
{
    Console.WriteLine($"Число {num1} кратно {num2}");
}
else
Console.WriteLine($"Остаток от деления {num1} на {num2} -> {num1%num2}");