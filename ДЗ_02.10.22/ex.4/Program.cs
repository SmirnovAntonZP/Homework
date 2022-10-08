// 4 - Программа проверяет пятизначное число на палиндромом.

// Первый способ решения

Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

if(n < 9999 || n > 99999)
    Console.WriteLine("Не является пятизначным числом.");

else
{
    int a = (n / 10000);
    int b = ((n % 10000) / 1000);
    int c = (((n % 10000) % 1000) / 100);
    int d = ((((n % 10000) % 1000) % 100) / 10);
    int e = ((((n % 10000) % 1000) % 100) % 10);
    /* Необязательные строки, для самопроверки
    Console.WriteLine (a);
    Console.WriteLine (b);
    Console.WriteLine (c);
    Console.WriteLine (d);
    Console.WriteLine (e); */
  
    int reverse = (e * 10000) + (d * 1000) + (c * 100) + (b * 10) + (a);
    //Console.WriteLine (reverse); - строка для самопроверки

        if(n == reverse)
        {
         Console.WriteLine("Число является палиндромом");
        }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
} 

/* Второй способ решения

Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

if(n < 9999 || n > 99999)
    Console.Write("Не является пятизначным числом");

else
{
    int num = n;
    int revnum = 0;

    while (n > 0)
    {
        int n1 = n % 10;
        revnum = revnum * 10 + n1;
        n = n / 10;
    }

        Console.Write(num == revnum ? "Число является палиндромом" : "Число не является палиндромом");
}*/




