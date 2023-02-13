// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Random rnd = new Random();
int m = rnd.Next(4,6);
int n = rnd.Next(4,6);
int[,] array = new int [m,n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rnd.Next(01,10);
            }
    }
System.Console.WriteLine();

NumberRowMinSumElements(array);
void NumberRowMinSumElements(int[,] array)
{
    int minStr = 0;
    int minSumStr = 0;
    int sumStr = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        minStr = minStr + array[0, i];
    }
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        sumStr = sumStr + array[i, j];
        if (sumStr < minStr)
        {
            minStr = sumStr;
            minSumStr = i;
        }
        sumStr = 0;
    }
    System.Console.WriteLine($"Строка № {minSumStr}");
}
for (int i = 0; i < array.GetLength(0); i++)        
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

