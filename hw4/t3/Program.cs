// See https://aka.ms/new-console-template for more information

// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

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

int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение массива");
int maxValue = Prompt("Введите максимальное значение массива");

PrintArray (GenArray(Range, minValue, maxValue));