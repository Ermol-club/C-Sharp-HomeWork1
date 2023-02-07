// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

System.Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] arr = new double [m,n];
Random rnd = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = new Random().Next(100);
        System.Console.Write(arr[i,j] + " ");
    }
    System.Console.WriteLine();
    
}
System.Console.WriteLine();
