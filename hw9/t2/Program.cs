// See https://aka.ms/new-console-template for more information
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int RecursiveSumBetween (int m, int n)
{
    int sum = 0;
    if (m == n + 1)
    {
        return sum;
    }
    return sum = m + RecursiveSumBetween (m + 1, n);
}
int start = Prompt ("Введите число, от которого считаем: ");
int finish = Prompt ("Введите число, до которого считаем: ");
Console.Write(RecursiveSumBetween (start, finish));