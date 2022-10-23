// 1 - Показать двумерный массив размером m×n заполненный вещественными числами

Console.Write("Введите количество строк матрицы (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов матрицы (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] RandomArray = new double[m, n]; 
Random random = new Random();
void FillArray(double[,] RandomArray)  
{
    for (int i = 0; i < RandomArray.GetLength(0); i++)
    {
        for (int j = 0; j < RandomArray.GetLength(1); j++)
        {
            RandomArray[i,j] = (random.NextDouble() + random.Next(0,10));
        }
    }
}

void PrintArray(double[,] RandomArray)
{
    for (int i = 0; i < RandomArray.GetLength(0); i++)
    {
        for(int j = 0; j < RandomArray.GetLength(1); j++ )
        {
            Console.Write($" {RandomArray[i, j]} ");
        }
        Console.WriteLine();
    }

}


FillArray(RandomArray);
Console.WriteLine();
PrintArray(RandomArray);
