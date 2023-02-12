// Задайте М и Н. Найдите сумму натуральных элементов от М до Н.

int m = 7;
int n = 15;
int Sum(int m, int n)
{
    if (n == m) return 0;
    else
    {
        return m + Sum(m+1, n);
    }
}
System.Console.WriteLine(Sum(m,n));



