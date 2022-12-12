// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write($"Введите размер массива: ");
int M = int.Parse(Console.ReadLine());
int[] numbers = ConsoleArray(M);
Console.WriteLine($"Количество положительных чисел: {NumberPozitive(numbers)}");


int[] ConsoleArray(int M)
{
    
    int[] array = new int[M];
    for (int i = 0; i<M; i++)
        {
            Console.Write($"Введите {i} элемент: ");
            array[i]=int.Parse(Console.ReadLine());
        }
    return array;
}



int NumberPozitive(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}
