/* Написать программу показывающие первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем */

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество чисел для показа: ");
int N = int.Parse(Console.ReadLine() ?? "0");

void NumSum(int a, int b, int n, int x)
{
    if (n <= x)
    {
        int sum = a + b;
        Console.Write($"{sum} ");
        NumSum(b,sum,n+1,x);
        
    }
}

NumSum(numA, numB, 1, N);
