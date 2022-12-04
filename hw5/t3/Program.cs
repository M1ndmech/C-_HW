// See https://aka.ms/new-console-template for more information

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

double NextDouble(Random rand, double minValue, double maxValue, int decimals)
    {
        double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
        return Convert.ToDouble(randNumber.ToString("f" + decimals));
    }

double [] GenArray (int length, int minRange, int maxRange, int decimalsN)
{
    double [] array = new double [length];
    for (int i = 0; i < array.Length; i++)
        {
            Random rand = new Random();
            double randNumber = NextDouble(rand, minRange, maxRange, decimalsN); 
            array[i] = randNumber;
        }
    return array;
}

double MinMaxDiff (double [] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] >= max)
        {
            max = array[i];
        }
        if (array [i] < min)
        {
            min = array[i];
        }
    }
    double diff = max - min;
    return diff;
}

int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение массива");
int maxValue = Prompt("Введите максимальное значение массива");
int decimalsN = Prompt("Введите максимальное количество знаков после запятой для значений массива");

double [] arr = GenArray(Range, minValue, maxValue, decimalsN);
double diffMinMax = MinMaxDiff (arr);
PrintArray (arr);
Console.WriteLine($"Разность минимального и максимального элементов - {diffMinMax:f2}");