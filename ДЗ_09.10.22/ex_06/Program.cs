// 6 - Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine() ?? "0");
void FillArray(int[] array)
{
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}
int[] array = new int[N];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] Pair(int[] arrayPair)
{
    int[] product = new int[arrayPair.Length / 2];
    int last = arrayPair.Length - 1;
    for (int i = 0; i < arrayPair.Length / 2; i++)
    {
        product[i] = arrayPair[i] * arrayPair[last];
        last = last - 1;
    }
    return product;
}
Console.WriteLine("Первый вариант:");
PrintArray(Pair(array));

