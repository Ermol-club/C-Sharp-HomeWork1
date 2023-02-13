// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Random rnd = new Random();
int m = 4;
int n = 6;
int[,] array = new int [m,n];
mySort(array);

for (int i = 0; i < array.GetLength(0); i++)        
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rnd.Next(1,10);
        System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}
mySort(array);
void mySort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;    
        for (int j = 0; j < array.GetLength(1); j++)    
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                    temp = array[i,k+1];
                    array[i,k+1]  = array[i,k];
                    array[i,k] = temp;                                      
                }                
            }            
        }
    }
    System.Console.WriteLine();
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
