// 2 - Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива. 

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray (int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}
int[] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

int PositiveSum = 0;
int NegativeSum = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        PositiveSum = PositiveSum + array[i];
    }
    if(array[i] < 0)
    {
        NegativeSum = NegativeSum + array[i];
    }
};

Console.WriteLine($"Сумма положительных элементов {PositiveSum}");
Console.WriteLine($"Сумма отрицательных элементов {NegativeSum}");
