// See https://aka.ms/new-console-template for more information

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int [] GenerateFillableArray (int length)
{
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
        {
            int a = Prompt($"Введите число №{i+1} ");
            array[i] = a;
        }
    return array;
}

int CountPositive (int [] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0) counter++;
    }
    return counter;
}

int fillLength = Prompt("Сколько чисел вы хотите ввести?");

int [] arr = GenerateFillableArray(fillLength);
PrintArray (arr);
Console.WriteLine($"Количество положительных значений в массиве - {CountPositive(arr)}");