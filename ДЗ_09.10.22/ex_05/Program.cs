// 5. Найти сумму чисел одномерного массива стоящих на нечетной позиции.
Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine() ?? "0");
void FillArray(int[]array)
{
    for(int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min,max);
    }
}
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}
int[] array = new int[N];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int OddNumSum = 0;
for(int i = 1; i < array.Length; i++)
{
    if(i % 2 == 1)
    {
        OddNumSum = OddNumSum + array[i];
    }
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {OddNumSum}");