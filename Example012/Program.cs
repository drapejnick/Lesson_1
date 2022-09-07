// Напишите программу, которая по заданному номеру четверти, показывает диапазон координат точек в этой четверти (x,y)

Console.Write("Введите номер четверти ");
int x = int.Parse(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}
if (x == 2)
{
    Console.WriteLine("x < 0 и y > 0");
}
if (x == 3)
{
    Console.WriteLine("x < 0 и y < 0");
}
if (x == 4)
{
    Console.WriteLine("x > 0 и y < 0");
}


