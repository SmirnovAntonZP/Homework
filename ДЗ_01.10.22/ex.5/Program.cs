// 5 - Показать числа от -N до N

Console.WriteLine("Enter number");
int n = int.Parse(Console.ReadLine());
int b = (n * -1);
if(n > 0)
{
    while (b <= n)
    {
        Console.WriteLine(b);
        b++;
    }
}
else
while(n <= b)
{
    Console.WriteLine(n);
    n++;
}
