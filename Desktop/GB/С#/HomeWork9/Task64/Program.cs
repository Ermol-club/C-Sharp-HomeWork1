// Задайте М и Н. Программа выводит все числа от М до Н.

int n = 3;;
int m = 10;;
NumRec(n,m);

void NumRec(int n, int m)
{
    if (m<n) return;
    else System.Console.Write($"{n},");
    NumRec(n+1,m);
}