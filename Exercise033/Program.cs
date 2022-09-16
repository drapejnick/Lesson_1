// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        if (i != res.Length - 1) Console.Write($"{res[i]}, ");
        else Console.Write($"{res[i]}]\r\n");
    }
    return res;
}
int count = 0;
Console.WriteLine("Введите число для проверки на наличие в массиве: ");
int n = int.Parse(Console.ReadLine());
Console.Write("массив [");
int[] array = GetArray(5, 0, 1);
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == n)
    {
        count++;
    }
}
Console.Write((count == 0 ? $"-> НЕТ" : $"-> ДА "));