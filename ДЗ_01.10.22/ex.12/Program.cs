// 12 - Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine() ?? "0");
int count = 0;
int i = n;
while (i > 0)
{
    if(n > 99)
    {
            i = i / 10;
            count++;
    }
    else
    {
        Console.WriteLine("Третья цифра отсутствует");
        break;
    }
}
int delitel = (int)(Math.Pow(10,count - 3));

int digit3 = (n / delitel) % 10;

Console.Write("Третья цифра числа равна " + digit3);
