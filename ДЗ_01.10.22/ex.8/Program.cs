// 8 - Показать вторую цифру трёхзначного числа.

// Первый вариант решения

Console.WriteLine("Введите трёхзначное число ");
int n = int.Parse(Console.ReadLine() ?? "0");
int first = n / 100; 
int second = (n / 10) % 10;
int third = n % 10;

if(n < 1000 && n > 99) 
{  
    // Необязательные строки, для собственной проверки
    Console.WriteLine(first);
    Console.WriteLine(second);
    Console.WriteLine(third);

    Console.WriteLine("Второе число - "  + second);
} 
else
{ 
    Console.WriteLine("Не является трёхзначным");
}

// Второй вариант решения
/*
Console.WriteLine("Enter a three-digit number");
string n = (Console.ReadLine() ?? "0");
Console.WriteLine(n[1]);
*/