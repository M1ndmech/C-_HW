// See https://aka.ms/new-console-template for more information
// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Не использовать строки

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int day = Prompt("Введите номер дня недели - а я скажу, выходной ли это");
switch (day) 
{
    case 1: System.Console.WriteLine("нет");break;
    case 2: System.Console.WriteLine("нет");break;
    case 3: System.Console.WriteLine("нет");break;
    case 4: System.Console.WriteLine("нет");break;
    case 5: System.Console.WriteLine("нет");break;
    case 6: System.Console.WriteLine("да");break;
    case 7: System.Console.WriteLine("да");break;
    default: System.Console.WriteLine("Это не день недели!");break;
}