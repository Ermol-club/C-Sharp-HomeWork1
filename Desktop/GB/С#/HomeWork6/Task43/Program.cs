// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Enter b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны.");
}
if (b1 == b2)
{
    Console.WriteLine("Прямые совпадают.");
}

int x = 0;
int y = 0;

x = (b2 - b1)/(k1 - k2);
y = k1 * x + b1;

Console.WriteLine("Точка пересечения прямых: " + "(" + x + ", " + y + ")" );
