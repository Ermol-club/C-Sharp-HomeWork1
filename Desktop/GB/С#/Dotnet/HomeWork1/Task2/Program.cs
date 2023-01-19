Console.Clear();
Console.WriteLine("Введите Первое число");
int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b < a)
{
    Console.WriteLine($"{a} - максимальное число");
}
else 
{
    Console.WriteLine($"{b} - максимальное число");
}

