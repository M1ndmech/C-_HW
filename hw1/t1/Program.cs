// See https://aka.ms/new-console-template for more information

// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int input1 = Prompt("Введите первое число");
int input2 = Prompt("Введите второе число");

if (input2 > input1)
{
    Console.WriteLine($"Число {input2} больше числа {input1} ");
}
else
{
    Console.WriteLine($"Число {input1} больше числа {input2} ");
}