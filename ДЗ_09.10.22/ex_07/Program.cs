// 7. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

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

int DiffMaxMin(int[] array)
{
    int MaxNum = array[0]; 
    int MinNum = array[0];
    int Diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxNum) MaxNum = array[i];
        if (array[i] < MinNum) MinNum = array[i];
        Diff = MaxNum - MinNum;
    }
    return Diff;
}

Console.WriteLine($"Разница между максимальным и минимальным числом {DiffMaxMin(array)}");
Console.WriteLine();
