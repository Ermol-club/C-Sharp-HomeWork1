// Программа, которая выводит третью цифру заданного числа, или сообщает что третьей цифры нет

Console.Clear();
System.Console.WriteLine("Введите число --> ");
int x = Convert.ToInt32(Console.ReadLine());

def f3(x);
    if (x >= 999)
    {
        while (x >= 999)
        x = x / 10;
        return (x % 1 * 10);
    }
    else
    {
        return;
    }







int Max(int a, int b)  //Функция
{
    if (a > b) return a;
    else return b;
}