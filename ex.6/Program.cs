// 6 - Показать четные числа от 1 до N

Console.WriteLine("Enter number");
int n = int.Parse(Console.ReadLine() ?? "0");
int a = 1;

if (n > 0);
{
    while (a <= n)
    {
        if(a % 2 == 0)
        {
            Console.WriteLine(a);
            a++;
        }
        else
        a++;   
    }
}