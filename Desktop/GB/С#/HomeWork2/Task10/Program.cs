// Программа, которая на вход получает трехзначное число и на выходе показывает вторую цифру этого числа

System.Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());

int firstNumbers = a / 10;            //Так находится первая и вторая цифры трехзначного числа (отсекается последняя)
int midle = firstNumbers % 10;         //Так находится вторая цифра двузначного числа

Console.WriteLine ($"{midle}");