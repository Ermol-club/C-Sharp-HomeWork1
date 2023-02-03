//ользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Enter your nubbers with  ---> ");
string str = Console.ReadLine();

char[] separator = new char[] {' ', '/'};
string[] array = str.Split(separator,StringSplitOptions.RemoveEmptyEntries);

int[] a = Array.ConvertAll(array,int.Parse);
Console.WriteLine("{"+string.Join(",",a)+"}");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (a[i]>0) count++;
}
Console.WriteLine("Positive elements: " + count);
