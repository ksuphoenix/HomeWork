// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Write($"x1=");
int x1 = int.Parse(Console.ReadLine());
Console.Write($"y1=");
int y1 = int.Parse(Console.ReadLine());
Console.Write($"x2=");
int x2 = int.Parse(Console.ReadLine());
Console.Write($"y2=");
int y2 = int.Parse(Console.ReadLine());

double distanse = Math.Sqrt( (Math.Pow((x1-x2),2)) + (Math.Pow((y1-y2),2)) );
Console.WriteLine($"distanse = {distanse:f3}");