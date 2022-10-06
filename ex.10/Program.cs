// 10 - Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число ");
int n = int.Parse(Console.ReadLine() ?? "0");
int first = n / 100; 
int second = (n / 10) % 10;
int third = n % 10;

if(n < 1000 && n > 99) 
{  
    // Необязательные строки, для проверки
    Console.WriteLine(first);
    Console.WriteLine(second);
    Console.WriteLine(third);

    Console.WriteLine(("Конечное число "  + first) + third);
} 
else
{ 
    Console.WriteLine("Не является трёхзначным");
}