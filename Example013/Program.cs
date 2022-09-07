// Напишите программу, которая на вход принимает координаты двух точек 
//и находит расстояние между ними в 2D пространстве. 
// A (3,6) B (2,1) -> 5,09
// A (7,-5) B (1,-1) -> 7,21
// d = √((хА – хВ)2 + (уА – уВ)2)

Console.Write("Введите координаты X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
double d = Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)), 2);

Console.WriteLine($"Длина отрезка = {d}");


