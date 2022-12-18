// See https://aka.ms/new-console-template for more information
// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив. 

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

int [,] GenerateSpiralMatrix (int rowsColumns)
{
    int [,] array = new int [rowsColumns, rowsColumns];
    int s = 1;
    int lenConst = array.GetLength(0);
    int lenReducable = array.GetLength(0);
    while (lenReducable > 0)
    {
    for (int i = lenConst - lenReducable; i < lenReducable; i++)
        {
        array[i, lenConst - lenReducable] = s;
        s++;
        }
            for (int j = lenConst - lenReducable + 1; j < lenReducable; j++)
            {
            array[lenReducable - 1, j] = s;
            s++;
            }
                for (int k = lenReducable - 1; k > lenConst - lenReducable; k--)
                {
                array[k - 1, lenReducable - 1] = s;
                s++;
                }
                    for (int l = lenReducable - 2; l > lenConst - lenReducable; l--)
                    {
                    array[lenConst - lenReducable, l] = s;
                    s++;
                    }
    lenReducable--;    
    }
    
    return array;
}

int rowsColumnsInput = Prompt("Введите количество строк/столбцов массива");

int [,] newMatrix = GenerateSpiralMatrix(rowsColumnsInput);

PrintMatrix (newMatrix);