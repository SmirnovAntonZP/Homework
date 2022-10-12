// 4 - Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число: ");
double n = double.Parse(Console.ReadLine() ?? "0");
double count = 1;

if (n >= 1)
{
    while (count <= n)
    {
        double result = Math.Pow(count, 3);
        if (result % 2 == 0)
        {
            Console.WriteLine(result);
            count++;
        }
        else
            count++;
    }
}
else
Console.WriteLine("Введенное число больше либо равно 0");