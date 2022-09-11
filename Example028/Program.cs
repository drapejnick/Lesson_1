// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N. 
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int Factorial(int num)
{
    int count = num;
    while (count > 1)
    {
        count--;
        num *= count;
    }
    return num;
}

Console.WriteLine($"{number} -> {Factorial(number)}");
