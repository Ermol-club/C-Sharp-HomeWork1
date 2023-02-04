//41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Enter your nubbers with  ---> ");
string str = Console.ReadLine();

char[] separ = new char[] {' ', '/'};
string[] array = str.Split(separ,StringSplitOptions.RemoveEmptyEntries);

int[] x = Array.ConvertAll(array,int.Parse);
Console.WriteLine("{"+string.Join(",",x)+"}");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (x[i]>0) count++;
}
Console.WriteLine("Elements > 0: " + count);
