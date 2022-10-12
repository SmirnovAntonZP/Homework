// 3 - Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int Fact = 1;

for (int count = 1; count <= n; count++)
{
    Fact = Fact * count;
}

Console.WriteLine("Произведение чисел от 1 до " + n + " равно " + Fact);
