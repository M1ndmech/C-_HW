// See https://aka.ms/new-console-template for more information

// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . Не использовать строки

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int inputN = Prompt("Введите число");
int search = Prompt("Введите номер искомой цифры с конца числа");
int count = 0;
int length = inputN;

while (length > 0)
{
    length = length / 10;
    count++;
}

if (search < count)
{
for (int i = 0; i < (search - 1); i++)
    {
    inputN = inputN / 10;
    }
inputN = inputN % 10;
Console.WriteLine(inputN);
}
else
{
    Console.WriteLine($"На этом месте цифры нет");
}
