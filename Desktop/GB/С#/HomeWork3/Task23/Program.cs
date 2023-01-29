// Gрограммf, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine("Enter your number -->");
int n = Convert.ToInt32(System.Console.ReadLine());
int i = 1;

while (i <= n)
{
    System.Console.Write(Math.Pow(i,3) + ", ");
    i++;
}


