// 1 - По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число ");
int B = int.Parse(Console.ReadLine() ?? "0");

if(B / A == A)
{
Console.Write(B + " является квадратом " + A);
}
else if((B / A) != A)
{
Console.Write(B + " не является квадратом " + A);
}