// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int [,] arr = new int [5,5];
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

System.Console.WriteLine("Введите позицию числа(x): ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите позицию числа(y): ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (m == i && n == j) 
        {      
            System.Console.Write(arr[i, j]); 
        }
    }
    
}
System.Console.WriteLine();