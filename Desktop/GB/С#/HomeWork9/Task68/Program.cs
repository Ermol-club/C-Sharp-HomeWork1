// Программа вычесления финкции Аккермана. Даны два неотрицательных числа.

int m = 1;
int n = 2;
int Akker(int m, int n)
{
        if (n == 0)
        return m + 1;
    else
        if (n == 0)
        return Akker(m - 1, 1);
    else
        return Akker(m - 1, Akker(m, n - 1));
}
Console.WriteLine(Akker(m, n));

