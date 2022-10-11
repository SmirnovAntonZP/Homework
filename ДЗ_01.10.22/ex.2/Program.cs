// 2 - По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели");
int n = int.Parse(Console.ReadLine() ?? "0");
if(n == 1)
    Console.WriteLine("Monday");
else if(n == 2)
    Console.WriteLine("Tuesday");
else if(n == 3)
    Console.WriteLine("Wednesday");
else if(n == 4)
    Console.WriteLine("Thursday");
else if(n == 5)
    Console.WriteLine("Friday");
else if(n == 6)
    Console.WriteLine("Saturday");
else if(n == 7)
    Console.WriteLine("Sunday");
else
    Console.WriteLine(n + " Не является номером дня недели ");