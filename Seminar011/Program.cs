//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
Console.WriteLine("a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("b:");
int b = int.Parse(Console.ReadLine());
if(Math.Pow(b,2) == a) 
{
    Console.WriteLine("a квадрат b");
} 
else
{
    Console.WriteLine("a не квадрат b");
}
Console.WriteLine($"{a}, {b}");

