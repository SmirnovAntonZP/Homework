// 11 - Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите первое число : ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число для проверки кратности первому: ");
int a = int.Parse(Console.ReadLine() ?? "0");

if(n >= a && n % a == 0 && a > 0)
    Console.WriteLine(n + " кратно " + a);

else if (n >= a && n % a != 0 && a > 0)    
{
    Console.WriteLine(n + " некратно " + a);
    Console.WriteLine("Остаток " + n % a); 
} 
else
{
    Console.WriteLine("Проверка не может быть выполнена!");
}