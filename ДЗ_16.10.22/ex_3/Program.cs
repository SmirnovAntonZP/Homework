// 3 - В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.Write("Введите количество строк матрицы (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов матрицы (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] RandomArray = new int[m, n]; 
Random random = new Random();

void FillArray(int[,] RandomArray)  
{
    for (int i = 0; i < RandomArray.GetLength(0); i++)
    {
        for (int j = 0; j < RandomArray.GetLength(1); j++)
        {
            RandomArray[i,j] = (random.Next(0,10));
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

void ExponentElements(int[,] RandomArray)  
{
    for (int i = 0; i < RandomArray.GetLength(0); i++)
    {
        for (int j = 0; j < RandomArray.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
                RandomArray[i, j] = RandomArray[i, j] * RandomArray[i, j];
            
            else
            RandomArray[i, j] = RandomArray[i, j];
        }
    }
}


FillArray(RandomArray);
Console.WriteLine();
PrintArray(RandomArray);
Console.WriteLine();
ExponentElements(RandomArray);
Console.WriteLine();
PrintArray(RandomArray);
Console.WriteLine();