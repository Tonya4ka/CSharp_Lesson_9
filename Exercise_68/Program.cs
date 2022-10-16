// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
Console.Clear();
Console.Write("Type a number M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Type a number N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Akkerman function from numbers {m} and {n} equal {AkkermanFun(m, n)}");

int AkkermanFun(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFun(m - 1, 1);
    }
    else
    {
        return (AkkermanFun(m - 1, AkkermanFun(m, n - 1)));
    }
}
