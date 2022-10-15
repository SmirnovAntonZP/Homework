// 4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

Console.WriteLine("Введите минимальное число для заполнения массива: ");
int MinNumb = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите максимальное число для заполнения массива: ");
int MaxNumb = int.Parse(Console.ReadLine() ?? "0");
void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(MinNumb, MaxNumb);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

int[] array = new int[123];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int AmountElements = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] >= 10 && array[i] <= 99)
        AmountElements++;
}
Console.WriteLine("Количество элементов из отрезка [10,99] : " + AmountElements);