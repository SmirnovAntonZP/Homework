// 2. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.Write("Введите количество строк массива:");
int raw = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива:");
int col = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение элемента: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное значение элемента: ");
int max = int.Parse(Console.ReadLine() ?? "0");

int[,] Array = new int[raw, col];
int[,] matrix = fillArray(raw, col, min, max);
int[] minPosition = findMinElemRawCol(matrix);
int[,] matrixWithoutRawCol = deleteRawCol(matrix, minPosition);

int[,] fillArray(int raw, int col, int min, int max)
{
    int[,] array = new int[raw, col];
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
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] findMinElemRawCol(int[,] array)     
{
    int[] numbers = new int[] { 0, 0 };
    int minNumber = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minNumber)
            {
                minNumber = array[i, j];
                numbers[0] = i;
                numbers[1] = j;
            }
        }
    }
    return numbers;
}

int[,] deleteRawCol(int[,] Array, int[] array)
{
    int[,] array2 = new int[Array.GetLength(0) - 1, Array.GetLength(1)]; 
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (i < array[0]) array2[i, j] = Array[i, j];
            else array2[i, j] = Array[i + 1, j];
        }
    }
    int[,] resultArray = new int[array2.GetLength(0), array2.GetLength(1) - 1]; // удаляем столбец из массива с удаленной строкой
    {
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                if (j < array[1]) resultArray[i, j] = array2[i, j];
                else resultArray[i, j] = array2[i, j + 1];
            }
        }
    }
    return resultArray;
}

printArray(matrix);
printArray(matrixWithoutRawCol);