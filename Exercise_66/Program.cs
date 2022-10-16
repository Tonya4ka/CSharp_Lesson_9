// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно
Console.Clear();
Console.Write("Type a number M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Type a number N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum: {SumRecNumbers(m, n)}");
SumRecNumbers(m, n);

int SumRecNumbers(int m, int n)
{
    if (m < n)
    {
        return m + SumRecNumbers(m+1,n);
    }
    else
    {
        return n;
    }
}