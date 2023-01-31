// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] arr = new int[8];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1000);
    System.Console.Write(arr[i] + " ");
}

int maxNumber = 0;
int minNumber = 999;
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
System.Console.WriteLine("\n" + "Максимальный элемент: " + maxNumber + "\n" + "Минимальный элемент: " + minNumber);




