// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// со сторонами такой длины. 

Console.Clear();
Console.Write($"(Введите стороны треугольника: а, в, с )");
string strNumber = Console.ReadLine();
string[] points = strNumber.Split(',');
int[] intPoints = new int[3];
int count = 0;

foreach (string el in points)
{
    intPoints[count] = int.Parse(el);
    count++;
}
if (intPoints[0] < intPoints[1] + intPoints[2] && intPoints[1] < intPoints[0] + intPoints[2] && intPoints[2] < intPoints[1] + intPoints[0])
{
    Console.WriteLine("Треугольник может существовать");
}
else
{
    Console.WriteLine("Треугольник не может существовать");
}



