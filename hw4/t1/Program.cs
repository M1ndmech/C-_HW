// See https://aka.ms/new-console-template for more information

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int Exp (int number, int exponent)
{
    int newNum = 1;
    for (int i = 0; i < exponent; i++)
    {
        newNum = newNum * number;
    }
    return newNum;
}

int valA = Prompt ("Введите число");
int valB = Prompt ("Введите степень");
int exp = Exp (valA, valB);

Console.WriteLine($"Число {valA} в степени {valB} равно {exp}");
