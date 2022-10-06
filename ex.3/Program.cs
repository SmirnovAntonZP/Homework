// 3 - Найти максимальное из трех чисел

Console.WriteLine("Enter first number: ");
int n1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Enter second number: ");
int n2 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Enter third number: ");
int n3 = int.Parse(Console.ReadLine()?? "0");
int max = n1;

if (n1 > max) max = n1;
if(n2 > n1) max = n2;
if(n3 > max) max = n3;

Console.WriteLine ("max = " + max);
