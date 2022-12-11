// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Каждое следующее равно сумме двух предыдущих.

// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34


int N = int.Parse(Console.ReadLine());
int[] array = Fibonacci(N);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] Fibonacci(int N)
{ 
    int[] array = new int [N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i<N; i++)
    {
        array[i] = array[i-1] + array[i-2];   
    }
    return array;
}