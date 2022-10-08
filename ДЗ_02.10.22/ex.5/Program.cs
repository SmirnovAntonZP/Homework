// 5 - Найти расстояние между точками в пространстве 2D/3D.

 Console.Write("Введите координаты x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

// Для поиска в 3d пространстве
Console.Write("Введите координаты z1 (если не требуется, введите 0): ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2 (если не требуется, введите 0): ");
double z2 = Convert.ToDouble(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками {distance}");
