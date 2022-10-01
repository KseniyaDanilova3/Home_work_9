//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число:");;
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int n  = int.Parse(Console.ReadLine()!);

int sum = 0;
Console.WriteLine($"{SumNumbers(m,n)}");

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return sum += n;
    }
    else
    {
        return sum = sum + m + SumNumbers(m + 1, n);
    }
}

