// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи 0 и 1. 
// Если N = 5 -> 01123
// Если N = 3 -> 001
// Если N = 7 -> 001123 5 8

Console.Clear();

void Fibonacci(double[] array)
{
    int count = 3;
    while (count < array.Length)
    {
        array[count] = array[count - 1] + array[count - 2];
        count++;
    }
}

int N = new Random().Next(0, 10);
double[] arr = new double[N];
arr[0] = 0;
arr[1] = 1;
arr[2] = 1;

Fibonacci(arr);

foreach (double el in arr)
{
    Console.Write($"{el} ");
}


