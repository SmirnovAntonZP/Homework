// Найти сумму элементов от M до N, N и M заданы

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");


int SumNumbers(int a, int b)
{
    if (a == b) return b;
    return a + SumNumbers(a + 1, b);
}

if (M > N) Console.WriteLine($"сумма элементов = " + SumNumbers(N, M));
    else Console.WriteLine($"сумма элементов = " + SumNumbers(M, N));

if (M == N) Console.WriteLine(M + " = " + N);
