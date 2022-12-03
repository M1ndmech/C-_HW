// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int Counter (int number)
{
    int count = 0;
    while (number > 0)
        {
            count++;
            number /= 10;
        }
    return count;
}

int Reverse (int number)
{
    int count = 0;
    int newNum = 0;
    while (number > 0)
    {
       newNum = newNum * 10 + number % 10;
       number /= 10;
    }
    return newNum;
}

int number = Prompt ("Введите число:");

if (number == Reverse(number))
{
    Console.WriteLine($"Число {number} - палиндром");
}
else
{
    Console.WriteLine($"Число {number} - не палиндром");
}