// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Write("Введите количество строк (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

if (m != n)
{
    int[,] array = new int[m, n];

    Random randomElements = new Random();

    void fillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = randomElements.Next(0, 10);
            }
        }
    }

    void printArray(int[,] array)
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

    int rowNumber(int[,] array)
    {
        int index = 0;
        int sum = 0;
        int result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[i, j];
            }
            if (i == 0) result = sum;
            else if (sum < result)
            {
                result = sum;
                index = i + 1;
            }
        }
        return index;
    }
    fillArray(array);
    printArray(array);
    Console.WriteLine();

    int index = rowNumber(array);
    Console.WriteLine(index);


}
else Console.WriteLine("Не является прямоугольником");

