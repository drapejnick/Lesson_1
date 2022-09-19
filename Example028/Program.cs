// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N. 
// 4 -> 24
// 5 -> 120

Console.Clear();
int[] array = new int[8];

int Random(int arr)
{
    int count = num;
    while (count > 1)
    {
        count--;
        num *= count;
    }
    return num;
}

Console.WriteLine($"{array} -> {Random(array)}");
