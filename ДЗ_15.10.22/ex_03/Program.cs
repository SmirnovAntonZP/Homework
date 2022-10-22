// 3 - Написать программу копирования массива

Console.Write("Введите длинну массива: "); // Заполнение массива рандомное
int N = int.Parse(Console.ReadLine() ?? "0");

int[] Array = new int[N];
FillArray(Array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}
int[] CopyArray(int[] array)

{
    int[] ArrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        ArrayCopy[i] = array[i];
    }
    return ArrayCopy;
}

Console.WriteLine("Заданный массив: ");
PrintArray(Array);
Console.WriteLine();
Console.WriteLine("Скопированный массив: ");
int[] Array_copy = CopyArray(Array);
PrintArray(Array_copy);
Console.WriteLine();
