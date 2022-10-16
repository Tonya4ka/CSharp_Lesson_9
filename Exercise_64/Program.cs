// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();
Console.Write("Type a number N: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
FillNumbers(n);

void FillNumbers(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        FillNumbers(n-1);
    }
}