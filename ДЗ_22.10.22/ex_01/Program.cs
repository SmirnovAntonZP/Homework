//1 - Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Console.Write("Введите количество строк (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m,n];
Random randomArray = new Random();

void FillArray (int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = (randomArray.Next(1,10));
        }
    }
}

void PrintArray(int[,]array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void StringTransformation (int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i ; j < array.GetLength(1) ; j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)                
            {
                if (array[i, j] >= array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
       
    }
    
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
StringTransformation(array);
PrintArray(array);