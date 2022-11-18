// Написать программу вычисления функции Аккермана

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int result = Accerman(n, m);

int Accerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Accerman(n - 1, 1);
    else
        return Accerman(n - 1, Accerman(n, m - 1));
}
Console.WriteLine();
Console.WriteLine($"Функция Аккермана для чисел {n},{m} = {result}");
Console.WriteLine();
