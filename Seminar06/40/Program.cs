// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.


Console.Write($"Введите длину стороны A: ");
int A=int.Parse(Console.ReadLine());
Console.Write($"Введите длину стороны B: ");
int B=int.Parse(Console.ReadLine());
Console.Write($"Введите длину стороны C: ");
int C=int.Parse(Console.ReadLine());
if (GetTriangle(A,B,C)) 
{
    Console.WriteLine($"Треугольник существует");
}
else Console.WriteLine($"Треугольник не существует");


bool GetTriangle(int A, int B, int C)
{
    return (A+B > C && A+C > B && B+C > A);
}
