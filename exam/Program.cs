// Написать программу, из имеющегося массива строк формирующую массив из строк, длина которых меньше либо равна 3 символам.
// Не использовать коллекции, только массивы

void PrintArray (string [] array)
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

string PromptString(string message)
{
    System.Console.Write($"{message}>");
    string answer = Console.ReadLine();
    return answer;
}

string [] GenStringArray (int length)
{
    string [] array = new string [length];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = PromptString($"Введите {i+1} значение:");
        }
    return array;
}

string [] LeaveShortValues (string [] arr, int len)
{
    int j = 0;
    string [] array = new string [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= len)
        {
            array[j] = arr[i];
            j++;
        }
    }
    string [] shortArray = new string [j];
    for (int k = 0; k < j; k++)
    {
        shortArray[k] = array [k];
    }
    return shortArray;
}

int range = Prompt("Введите длину массива ");
string [] arr = GenStringArray(range);
PrintArray (arr);

int length = Prompt("Введите максимальное количество символов в значении для его сохранения:");
PrintArray(LeaveShortValues(arr, length));