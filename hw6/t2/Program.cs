// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    System.Console.Write($"{message}>");
    double answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

(double?, double?) CalculateCrossing (double k1, double b1, double k2, double b2)
{
    if (k1 != k2)
    {
        double xCross = (b2 - b1)/(k1 - k2);
        double yCross  = xCross * k1 + b1;
        return (xCross, yCross);
    }
    return (null, null);
}

double k1 = Prompt("Введите коэффициент наклона прямой 1 (k1)");
double b1 = Prompt("Введите коэффициент смещения прямой 1 (b1)");
double k2 = Prompt("Введите коэффициент наклона прямой 2 (k2)");
double b2 = Prompt("Введите коэффициент смещения прямой 2 (b2)");

(double? coordX, double? coordY) = CalculateCrossing (k1, b1, k2, b2);

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine ($"Прямые совпадают");
}
else 
if ((coordX, coordY) == (null, null))
{
    Console.WriteLine ($"Прямые не пересекаются");
}
else
Console.WriteLine ($"Точка пересечения линий - {coordX:f3}, {coordY:f3}");