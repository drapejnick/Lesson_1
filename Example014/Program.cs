// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
// 5, -> 1,4,9,16,25
// 2, -> 1,4

Console.Write("Введите число ");
int x = int.Parse(Console.ReadLine());
int count = 1;

Console.Write($"{x} -> ");
while (count <= x)
{
    Console.Write($" {Math.Pow((count), 2)} ");
    count++;
}
