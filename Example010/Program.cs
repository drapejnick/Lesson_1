// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 
// 5, 25 -> да
// 8, 9 -> нет

Console.Write("Введите первое число, а ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число, b ");
int b = int.Parse(Console.ReadLine());

if (a * a == b | b * b == a)
{
    Console.WriteLine($"а = {a}, b = {b} -> да");
}
else
{
    Console.WriteLine($"а = {a}, b = {b} -> нет");
}