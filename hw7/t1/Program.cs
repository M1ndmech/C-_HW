// See https://aka.ms/new-console-template for more information

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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

float [,] GenerateFloatMatrix (int rows, int columns, int minRange, int maxRange)
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

int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

float [,] matrix1 = GenerateFloatMatrix(rowsInput, columnsInput, min, max);
PrintMatrix (matrix1);