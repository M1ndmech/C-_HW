// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int DigitSum (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number%10;
        number /= 10;
    }
    return sum;
}

int valA = Prompt ("Введите число");
int digitSum = DigitSum (valA);
Console.WriteLine($"Сумма цифр числа {valA} равна {digitSum}");