// See https://aka.ms/new-console-template for more information

// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int inputN = Prompt("Введите трёхзначное число");

if (inputN >= 100 && inputN < 1000)
{
    int seconddigit = (inputN % 100) / 10;
    Console.WriteLine(seconddigit);
}
else    
Console.WriteLine($"Число не трёхзначное");