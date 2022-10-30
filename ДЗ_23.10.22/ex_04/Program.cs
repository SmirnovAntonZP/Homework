// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
//(a+b)^2 = a^2 + 2ab + b^2
//(a+b)^3 = a^3 + 3a^2b + 3ab^2 + b^3

Console.Write("Введите количество строк вывода в треугольнике паскаля: ");
int N = int.Parse(Console.ReadLine()??"0");

int [,] Array = new int [N+1,((N+1)*2+1)];

void FillArray(int[,] array)
{
    array[0,(array.GetLength(1)/2)]=1;  // позиция первого элемента
    for (int i = 1; i < array.GetLength(0); i++)
        for (int j = 1; j < array.GetLength(1)-1; j++)
        {   
            array[i, j] = array[i-1, j-1]+array[i-1, j+1];
        }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j]==0) Console.Write(" ");
                else {Console.Write($"{array[i,j]}" );}
            }
            Console.WriteLine();
    }
}

FillArray(Array);
PrintArray(Array);

