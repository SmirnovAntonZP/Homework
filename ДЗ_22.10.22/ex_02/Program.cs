// 2 - Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.Write("Введите количество строк (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

if (m == n)
{
    int[,] array = new int[m, n];
    int[,] changedArray = new int[m, n];
    

    Random randomArray = new Random();

    void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = randomArray.Next(0, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}");
            }
            Console.WriteLine();
        }
    }

    int[,] changeRowColumn(int[,] array)
    {
        int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newArray[i, j] = array[j, i];
            }
        }
        return newArray;
    }

    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    changedArray = changeRowColumn(array);
    PrintArray(changedArray);
}

else 
Console.WriteLine("Невозможно заменить строки на столбцы. Матрица не квадратная");