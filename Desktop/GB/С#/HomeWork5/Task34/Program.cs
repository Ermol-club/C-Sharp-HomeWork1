// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arr = new int[10];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
    Console.Write(arr[i] + " ");
}

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0)
    {
    count++;
    }
}
System.Console.WriteLine("\n" + "Кол-во четных элементов: " + count);