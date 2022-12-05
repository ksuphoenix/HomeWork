// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Номер четверти: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
    {
        Console.WriteLine($"x от 0 до бесконечности, y от 0 до бесконечности");
        break;
    }
    case 2: 
    {
        Console.WriteLine($"x от минус бесконечности до 0, y от 0 до бесконечности");
        break;
    }
    case 3:
    {
        Console.WriteLine($"x от минус бесконечности до 0, y от минус бесконечности до 0");
        break;
    }
    case 4:
    {
        Console.WriteLine($"x от 0 до бесконечности, y от минус бесконечности до 0");
        break;
    }
    default: 
    {
        Console.WriteLine($"Это не четверть");
        break;
    }
}