// Показать натуральные числа от M до N, N и M заданы

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

void PrintNumbers(int a, int b)
{
    if(a >= b)
    {
        Console.Write(a+" ");
        PrintNumbers(a-1, b);
    }
}

PrintNumbers(M , N);
Console.WriteLine();