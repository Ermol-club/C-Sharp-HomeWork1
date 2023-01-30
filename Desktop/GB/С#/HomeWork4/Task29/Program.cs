// 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] myArr = new int[8];
Random rnd = new Random();

for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = rnd.Next(10);
}

for (int i = 0; i < myArr.Length; i++)
{
        System.Console.Write("[" + myArr[i] + "] ");
}



