// 2 - Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.Write("Введите количество строк матрицы (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов матрицы (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] Array = new double[m, n]; 

void FillArray(double[,] Array)  
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = (i + j);
        }
    }
}

void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++ )
        {
            Console.Write($" {Array[i, j]} ");
        }
        Console.WriteLine();
    }

}


FillArray(Array);
Console.WriteLine();
PrintArray(Array);

