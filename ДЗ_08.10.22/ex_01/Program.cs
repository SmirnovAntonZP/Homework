// 1 - Найти кубы чисел от 1 до N
Console.Write("Введите число: ");
double n = double.Parse(Console.ReadLine() ?? "0");
double count = 1;

if (n > 0)
{
    while (count <= n)
    {
        double result = Math.Pow(count, 3);
        Console.WriteLine(count + " ^ 3 = " + result);
        count++;
    }
}

else 
{
    Console.WriteLine("Введенное число < 0");
}