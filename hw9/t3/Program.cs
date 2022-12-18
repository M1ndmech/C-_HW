// See https://aka.ms/new-console-template for more information

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int RecursiveAckerman (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 & m > 0)
    {
        return RecursiveAckerman (m - 1, 1);
    }
    return RecursiveAckerman (m - 1, RecursiveAckerman (m, n-1));
}
int a = Prompt ("Введите первый аргумент (лучше до 3): ");
int b = Prompt ("Введите второй аргумент (также лучше до 3): ");
Console.Write(RecursiveAckerman (a, b));