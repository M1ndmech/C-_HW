// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void PrintMatrix (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
            Console.WriteLine();
    }
}

void PrintArray (double [] array)
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

int [,] GenerateMatrix (int rows, int columns, int minRange, int maxRange)
{
    int [,] array = new int [rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(minRange, maxRange+1);
            }
        }
    return array;
}

double [] ColumnAverages (int [,] array)
{
    double [] averages = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
               sum += array [i, j];
            }
            averages[j] = sum / array.GetLength(0);
        }
    return averages;
}

int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

int [,] newMatrix = GenerateMatrix(rowsInput, columnsInput, min, max);
PrintMatrix (newMatrix);
Console.WriteLine();

PrintArray (ColumnAverages(newMatrix));
