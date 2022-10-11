// 9 - Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите число от 10 до 99");
int n = int.Parse(Console.ReadLine() ?? "0");
int first = n / 10; 
int second = n % 10;
int max = first;

if(n >= 10 && n<=99)
{
    if(second > first) max = second; 
        Console.WriteLine("Наибольшая цифра числа - " + max);
}
else
{
    Console.WriteLine("Введенное число не находится в необходимом пределе");
}

/* Второй вариант решения

Console.WriteLine("Введите число от 10 до 99");
String n = Console.ReadLine() ?? "0";

if(n[0] > n[1])
{
    Console.WriteLine("Наибольшая цифра числа - " + n[0]);
}
else 
{
   Console.WriteLine("Наибольшая цифра числа - " + n[1]);
} */