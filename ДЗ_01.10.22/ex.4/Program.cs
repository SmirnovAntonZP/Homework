// 4 - Выяснить является ли число чётным

Console.WriteLine("Enter a number");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(n%2==0 ? "Чётное" : "Нечётное");
