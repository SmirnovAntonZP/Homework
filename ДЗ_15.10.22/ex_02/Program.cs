//2 - Написать программу масштабирования фигуры

Console.Write("Задайте координаты фигуры через ',': ");
string[] Numb = (Console.ReadLine() ?? "0").Split(',');
Console.WriteLine();
Console.Write("Введите коэфициент масштабирования: ");
double k = double.Parse(Console.ReadLine() ?? "0");

double[] CoordArray(string[] Numb, double k)
{
    double[] array = new double[Numb.Length];
    for (int i = 0; i < Numb.Length; i++)
    {
        array[i] = (double.Parse(Numb[i])) * k;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i+=2)
    {
        Console.Write($"({array[i]}, {array[i+1]})  ");
    }
}

Console.WriteLine();
double[] ScaleCoord = CoordArray(Numb, k);
Console.WriteLine();
PrintArray(ScaleCoord);
Console.WriteLine();

