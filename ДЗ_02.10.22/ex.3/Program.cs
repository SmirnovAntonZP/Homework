// 3 - Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите координату X: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату Y: ");
int y = int.Parse(Console.ReadLine() ?? "0");

if ((x > 0) && (y > 0) && (x != 0) && (y != 0))
{
    Console.WriteLine("1 четверть");
} 
else if ((x < 0) && (y > 0) && (x != 0) && (y != 0))
{
    Console.WriteLine("2 четверть");
}
else if ((x < 0) && (y < 0) && (x != 0) && (y != 0))
{
    Console.WriteLine("3 четверть");
}
else if ((x > 0) && (y < 0) && (x != 0) && (y != 0))
{
    Console.WriteLine("4 четверть");
}
else
{
    Console.WriteLine("Невозможно определить четверть, Х или Y = 0");
}