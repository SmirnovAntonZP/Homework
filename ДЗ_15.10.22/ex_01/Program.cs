/* Найти точку пересечения двух прямых
уравнение y = k1 * x + b1
          y = k2 * x + b2
          b1,k1,b2,k2 - заданы

          k1 * x + b1 = k2 * x + b2 
          (k1 - k2) * x = b2 - b1 
          x = (b2 - b1) / (k1 - k2) 
          y = k1 * x + b1
*/

Console.WriteLine("Задайте координату k1 : ");
double k1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте координату b1 : ");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте координату k2 : ");
double k2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте координату b2 : ");
double b2 = double.Parse(Console.ReadLine() ?? "0");

double x = (b2-b1)/(k1-k2);
double y = k1*((b2-b1)/(k1-k2))+b1;

Console.WriteLine($"Точка пересечения прямых имеет координаты ({x}, {y})");