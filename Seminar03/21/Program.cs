// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write($"x1=");
int x1 = int.Parse(Console.ReadLine());
Console.Write($"y1=");
int y1 = int.Parse(Console.ReadLine());
Console.Write($"z1=");
int z1 = int.Parse(Console.ReadLine());
Console.Write($"x2=");
int x2 = int.Parse(Console.ReadLine());
Console.Write($"y2=");
int y2 = int.Parse(Console.ReadLine());
Console.Write($"z2=");
int z2 = int.Parse(Console.ReadLine());

double distanse = Math.Sqrt( (Math.Pow((x1-x2),2)) + (Math.Pow((y1-y2),2)) + (Math.Pow((z1-z2),2)) );
Console.WriteLine($"distanse = {distanse:f3}");