// Задача на определение, является ли введенное число чётным (делится ли оно на два без остатка) или нет.

Console.Clear();
Console.WriteLine("Введите число:");
int a  = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"{a} - число четное");
} 
else
{
Console.WriteLine($"{a} - число нечетное");
}