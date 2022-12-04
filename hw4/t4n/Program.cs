// See https://aka.ms/new-console-template for more information

// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5


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

int SecondMax (int [] array)
{
    int max = array[0];
    int max2nd = int.MinValue;
    for (int i = 1; i < array.Length; i++)
    {
        if (array [i] >= max)
        {
            max = array[i];
        }
        if (array [i] < max && array[i] >= max2nd)
        {
            max2nd = array[i];
        }
    }
    return max2nd;
}

int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение массива");
int maxValue = Prompt("Введите максимальное значение массива");

int [] arr = GenArray(Range, minValue, maxValue);
int maxsecond = SecondMax (arr);

PrintArray (arr);
Console.WriteLine($"Второе максимальное число - {maxsecond}");