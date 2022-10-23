// 1 - Показать двумерный массив размером m×n заполненный вещественными числами

Console.Write("Введите количество строк матрицы (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов матрицы (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

Random random = new Random();
void FillArray(int[,] RandomArray)  
{
    for (int i = 0; i < RandomArray.GetLength(0); i++)
    {
        for (int j = 0; j < RandomArray.GetLength(1); j++)
        {
            RandomArray[i,j] = random.Next(0,10);
        }
    }
}

void PrintArray(int[,] RandomArray)
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

int[,] RandomArray = new int [m, n]; 

FillArray(RandomArray);
Console.WriteLine();
PrintArray(RandomArray);
