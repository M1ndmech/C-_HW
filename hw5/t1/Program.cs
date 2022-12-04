// See https://aka.ms/new-console-template for more information

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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

int [] GenArray (int length, int minRange, int maxRange)
{
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minRange, maxRange+1);
        }
    return array;
}

int CountEven (int [] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0) counter++;
    }
    return counter;
}

int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение массива");
int maxValue = Prompt("Введите максимальное значение массива");

int [] arr = GenArray(Range, minValue, maxValue);
int countEven = CountEven(arr);
PrintArray (arr);
Console.WriteLine($"Количество четных значений в массиве - {countEven}");