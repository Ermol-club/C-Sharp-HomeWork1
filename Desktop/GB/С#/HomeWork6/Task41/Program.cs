//41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Enter your nubbers через запятую ---> ");
//string str = Console.ReadLine();


int[] m = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
Console.WriteLine("{"+string.Join(",",x)+"}");

int count = m.Count(x => x > 0);
//for (int i = 0; i < array.Length; i++)
//{
    //if (x[i]>0) count++;
//}
Console.WriteLine($"Elements > 0: {count}");
