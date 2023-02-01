// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arr = new double[8];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.NextDouble()*20;
    System.Console.WriteLine(arr[i] + " ");
}

double maxNumber = 0;
double minNumber = 999;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > maxNumber)
    {
        maxNumber = arr[i];
    }

    if(arr[i] < minNumber)
    {
        minNumber = arr[i];
    }
}
double diff = maxNumber - minNumber;

System.Console.WriteLine("\n" + "Максимальный элемент: " + maxNumber + "\n" + "Минимальный элемент: " + minNumber);
System.Console.WriteLine("Разница между min и max = " + diff);




