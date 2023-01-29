// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
System.Console.WriteLine("Введите пятизначное число");

int a = Convert.ToInt32(Console.ReadLine());

int firstNumber = a /10000;                                         // Определение первой цифры числа
int lastNumber = a % 10;                                            // Определение последней цифры числа
int secondNumber = (a / 1000) % 10;
int forthNumber = (a % 100) / 10;

if ((firstNumber == lastNumber) && (secondNumber == forthNumber))
{
    Console.WriteLine("O, Да!");
} 

else System.Console.WriteLine("Oh? now!");
