// 1 - Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

int Numbers = 8; 

int[] FillArray(int x)
{
    int[] arr = new int[x];
    for(int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]}");
    }
}

PrintArray(FillArray(Numbers));
Console.WriteLine();