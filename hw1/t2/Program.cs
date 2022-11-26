// See https://aka.ms/new-console-template for more information
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int input1 = Prompt("Введите первое число");
int input2 = Prompt("Введите второе число");
int input3 = Prompt("Введите второе число");

int max = 0;

if (input2 > input1)
{
    max = input2;
}
else 
{
    max = input1;
}

if (input3 > max)
{
    Console.WriteLine($"MAX = {input3}");
}
else
{
    Console.WriteLine($"MAX = {max}");
}
