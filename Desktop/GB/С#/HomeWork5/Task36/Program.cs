// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

int[] arr = new int[8];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100);
    System.Console.Write(arr[i] + " ");
}
System.Console.WriteLine();

int sum = 0;
for (int i = 1; i < arr.Length; i=i+2)
{
    sum = sum + arr[i];
}
System.Console.WriteLine("Сумма = "+ sum);