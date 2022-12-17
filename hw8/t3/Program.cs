// See https://aka.ms/new-console-template for more information
// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int [,] MultiplyMatrix (int [,] matrix1, int [,] matrix2)
{
    int [,] newMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                newMatrix [i,j] += matrix1 [i, k] * matrix2 [k, j];
            }
        }
    }
    return newMatrix;
}

// Вспоминаем теорию - умножение двух матриц возможно только при равенстве количества столбцов 1й количеству строк 2й. 
// Можно сделать проверку, но пока в качестве обхода для решения основной задачи зададим их равными.
// Значение Сij в целевой матрице будет равно сумме произведений значений строки i матрицы 1 на значения столбца j матрицы 2.
// Размерность итоговой матрицы будет равна кол-во строк 1 массива * кол-во столбцов 2 массива.

int rowsInput1 = Prompt("Введите количество строк 1 массива");
int columnsInput = Prompt("Введите количество столбцов 1 массива/строк 2 массива");
int columnsInput2 = Prompt("Введите количество столбцов 2 массива");
int min1 = Prompt("Введите минимальное значение для ячеек 1 массива");
int max1 = Prompt("Введите максимальное значение для ячеек 1 массива");
int min2 = Prompt("Введите минимальное значение для ячеек 2 массива");
int max2 = Prompt("Введите максимальное значение для ячеек 2 массива");

int [,] newMatrix1 = GenerateMatrix(rowsInput1, columnsInput, min1, max1);
int [,] newMatrix2 = GenerateMatrix(columnsInput, columnsInput2, min2, max2);
int [,] multiplyResult = MultiplyMatrix (newMatrix1, newMatrix2);

PrintMatrix (newMatrix1);
Console.WriteLine();
PrintMatrix (newMatrix2);
Console.WriteLine();
PrintMatrix (multiplyResult);
