// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Enter 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number: ");
int b = Convert.ToInt32(Console.ReadLine());
int summ = 1;

for ( int i = 0; i < b; i++ )
    {
        summ = summ * a;
    }
Console.WriteLine("Result = " + summ + ".");