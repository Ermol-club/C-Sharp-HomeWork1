// Программа, определяющая по введенному числу день недели, выхлдной или нет

System.Console.Write("Введите номер дня --> ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a >= 1)&&(a <= 5))
{
    Console.WriteLine("Это будний день");
}

if ((a >= 6)&&(a <= 7))
{
    Console.WriteLine("Это выходной день");
}
if ((a == 0)&&(a >=8 ))
{
    Console.WriteLine("Введите номер дня от 1 до 7");
}





//{
//    System.Console.Write("--> ");
//    number = Convert.ToInt32(Console.ReadLine());
//    return number;
//}
//
//double num = newNumber();
//if ((num % 7 == 0)&&(num % 23 == 0))              //Так мы проверяем делится ли число без остатка на 7 и 23
//{
//    System.Console.WriteLine(num + " кратно 7 и 23");
//}
//else 
//{
//   System.Console.WriteLine(num + " не кратно 7 и 23");
//} 
