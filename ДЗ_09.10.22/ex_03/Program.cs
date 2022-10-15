// 3 - Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

 void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int EvenNumbers = 0;
int OddNumbers = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
        EvenNumbers++;

    if(array[i] % 2 == 1)
        OddNumbers++;
}


Console.WriteLine("Количество четных чисел: " + EvenNumbers);
Console.WriteLine("Количество нечетных чисел: " + OddNumbers);
