// 2 - По двум заданным числам проверять является ли одно квадратом другого

// Первый способ решения

Console.Write("Введите первое число: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double B = Convert.ToDouble(Console.ReadLine());

if(A == B * B)
Console.Write(A + " является квадратом " + B);

else if(B == A * A)
Console.Write(B + " является квадратом " + A);

else
Console.Write("Ни одно из заданных чисел не является квадратом другого");

// Второй способ

/*
Console.Write("Введите первое число: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double B = Convert.ToDouble(Console.ReadLine());
if (A == B * B) Console.Write(A + " является квадратом " + B );
if (B == A * A) Console.Write(B + " является квадратом " + A);
if (A != B * B && B != A * A) Console.Write("Ни одно из заданных чисел не является квадратом другого.");
*/