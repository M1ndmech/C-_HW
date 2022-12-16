// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Можно ли без циклов?

void PrintMatrix (float [,] array)
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

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

float NextFloat(Random rand, double minValue, double maxValue)
    {
        double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
        return Convert.ToSingle(randNumber);
    }

float [,] GenerateMatrix (int rows, int columns, int minRange, int maxRange)
{
    float [,] array = new float [rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Random rand = new Random();
                float randNumber = NextFloat(rand, minRange, maxRange); 
                array[i,j] = randNumber;
            }
        }
    return array;
}

float? ValueLookup (float [,] matrix, int iPos, int jPos)
{
    if ( iPos <= (matrix.GetLength(0) - 1) 
         && iPos >= 1 
         && jPos < (matrix.GetLength(1) - 1)
         && jPos >= 1
         )
        {
            var value = matrix [iPos-1, jPos-1];
            return value;
        }
    else 
        {
        return null;
        }
    
}

int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

float [,] matrix1 = GenerateMatrix(rowsInput, columnsInput, min, max);
PrintMatrix (matrix1);

int lookupRow = Prompt("Введите номер строки требуемого элемента");
int lookupColumn = Prompt("Введите номер столбца требуемого элемента");

var lookupValue = ValueLookup(matrix1, lookupRow, lookupColumn);

if (lookupValue == (null))
{
    Console.WriteLine ($"Значение не найдено");
}
else 
Console.WriteLine($"Значение на искомой позиции - {lookupValue}");