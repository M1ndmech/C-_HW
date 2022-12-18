// See https://aka.ms/new-console-template for more information
// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

void RecursiveEvenNumbers (int m, int n)
{
    if (m == n + 1)
    {
        return;
    }
    if (m % 2 == 0)
    {
    Console.WriteLine(($"{m}; "));  
    }
    RecursiveEvenNumbers (m + 1, n);
}
int start = Prompt ("Введите число, от которого считаем: ");
int finish = Prompt ("Введите число, до которого считаем: ");
RecursiveEvenNumbers (start, finish);