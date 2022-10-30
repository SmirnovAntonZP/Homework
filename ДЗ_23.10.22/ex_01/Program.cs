// 1. Найти произведение двух матриц

Console.Write("Введите количество строк матрицы:");
int m1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов матриц: ");
int n1 = int.Parse(Console.ReadLine() ?? "0");

int[,] array1 = fillArray(m1, n1, 1, 10);
int[,] array2 = fillArray(m1, n1, 1, 10);
int[,] product = MultiplyMatrix(array1, array2);

int[,] fillArray(int m1, int n1, int min, int max)
{
    int[,] array = new int[m1, n1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] product = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int x = 0; x < array2.GetLength(0); x++)
            {
                product[i, j] = product[i, j] + (array1[i, x]) * (array2[x, j]);
            }
        }

    }
    return product;
}

printArray(array1);
Console.WriteLine();
printArray(array2);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
printArray(product);