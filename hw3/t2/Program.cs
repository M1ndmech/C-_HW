// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int xA = Prompt("Введите X для точки A");
int yA = Prompt("Введите Y для точки A");
int zA = Prompt("Введите Z для точки A");
int xB = Prompt("Введите X для точки B");
int yB = Prompt("Введите Y для точки B");
int zB = Prompt("Введите Z для точки B");
int deltaX = xB - xA;
int deltaY = yB - yA;
int deltaZ = zB - zA;

double distance = Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
Console.WriteLine($"Расстояние от A до B равно {distance:f3}");