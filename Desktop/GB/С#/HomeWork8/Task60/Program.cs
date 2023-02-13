// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2

Random rnd = new Random();
int x = 2;
int y = 2;
int z = 2;
int[,,] array3D = new int[x, y, z];
Console.WriteLine();

// // if ((X * Y * Z) < -89)
// if ((X * Y * Z) > 89)
// if ((X * Y * Z) < -90)
if ((x * y * z) > 90)
{
    Console.WriteLine("Невозможно заполнить массив неповторяющимися двузначными числами. Измените размер массива.");
    return;
}
CreateArray3D(array3D, x, y, z);
Console.WriteLine();
PrintArray3D(array3D);
int[,,] CreateArray3D(int[,,] array, int x, int y, int z)
{
    //int numbers = rnd.Next(10, 99) ;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(10, 99); 
                //numbers++;                
            }
        }
    }
    return array;
}
void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}[{i},{j},{k}] ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}