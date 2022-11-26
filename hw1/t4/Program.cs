// See https://aka.ms/new-console-template for more information

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int input1 = Prompt("Введите число");
int start = 0;

while (start <= input1)
{
    System.Console.WriteLine(start);
    start += 2;
}

