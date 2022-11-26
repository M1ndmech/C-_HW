// See https://aka.ms/new-console-template for more information

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int input1 = Prompt("Введите число");


if (input1 % 2 == 0)
{
    Console.WriteLine($"Число {input1} чётное ");
}
else
{
    Console.WriteLine($"Число {input1} нечётное ");
}