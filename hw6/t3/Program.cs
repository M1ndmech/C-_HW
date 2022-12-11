// See https://aka.ms/new-console-template for more information

// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

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

int MatrixSumMaximumsInRows (int [,] array)
{
    int maxSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            int max = array[i,0];
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] > max)
                {
                    max = array[i,j];
                }
            }
            maxSum+=max;
        }
    return maxSum;
}

int MatrixSumMinimumsInColumns (int [,] array)
{
    int minSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = array[0,j];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i,j] < min)
                {
                    min = array[i,j];
                }
            }
            minSum+=min;
        }
    return minSum;
}

int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

int [,] newMatrix = GenerateMatrix(rowsInput, columnsInput, min, max);
int minMaxDiff = MatrixSumMaximumsInRows(newMatrix) - MatrixSumMinimumsInColumns (newMatrix);
PrintMatrix (newMatrix);
Console.WriteLine();
Console.Write($"Разность между суммой максимумов по строкам {MatrixSumMaximumsInRows(newMatrix)} и суммой минимумов по столбцам {MatrixSumMinimumsInColumns (newMatrix)} равна {minMaxDiff}");
