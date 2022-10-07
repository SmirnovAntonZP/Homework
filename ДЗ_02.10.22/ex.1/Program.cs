// 1 - Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

// 3 способа решения

// Первый способ решения

Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 && n == 7)
    Console.Write(n + " - является выходным.");
else
    Console.Write(n + "- не является выходным.");

/* Второй способ решения

Console.Write("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine() ?? "0");
if(n == 1)
    Console.WriteLine(n + " - понедельник, не является выходным днём.");
else if(n == 2)
    Console.WriteLine(n + " - вторник, не является выходным днём.");
else if(n == 3)
    Console.WriteLine(n + " - среда, не является выходным днём.");
else if(n == 4)
    Console.WriteLine(n + " - четверг, не является выходным днём.");
else if(n == 5)
    Console.WriteLine(n + " - пятница, не является выходным днём.");
else if(n == 6)
    Console.WriteLine(n + " - суббота, выходной день.");
else if(n == 7)
    Console.WriteLine(n + " - воскресенье, выходной день.");
else
    Console.WriteLine(n + " - не является номером дня недели ");
*/


/* Третий способ решения

   Console.Write("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine() ?? "0");
if(n >= 1 && n < 6 )
{
    Console.WriteLine(n + " - Будний день");
}
else if (n < 8 && n > 5)
{
    Console.WriteLine(n + " - выходной день");
}

else
{
    Console.WriteLine(n + "Не является номером дня недели");
}
*/ 



