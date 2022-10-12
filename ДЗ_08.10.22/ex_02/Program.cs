// 2 - Подсчитать сумму цифр в числе

Console.Write("Введите число : ");
int n = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
while (n > 0)
{
    int digit = n % 10;
    sum = sum + digit;
    n = n / 10;
}

System.Console.WriteLine("Сумма всех цифр числа = " + sum);

