// Задача на нахлждение максимального из трех чисел

Console.Clear();
Console.WriteLine("Введите Первое число");
int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c  = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число из трех = ");
Console.WriteLine(max);
