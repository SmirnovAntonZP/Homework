// 7 - Показать последнюю цифру трёхзначного числа

// Первый способ

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

    Console.WriteLine("Третье число - "  + third);
} 
else
{ 
    Console.WriteLine("Не является трёхзначным");
}
 

/* Второй вариант решения
Console.WriteLine("Введите число ");
string n = (Console.ReadLine() ?? "0");
Console.WriteLine(n[2]);
*/