// See https://aka.ms/new-console-template for more information

// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета

// 456 -> 46
// 782 -> 72
// 918 -> 98

int inputN = new Random().Next(100, 1000);

Console.WriteLine($"Изначальное число {inputN}");

int newNum = (inputN / 100) * 10 + (inputN % 10);

Console.WriteLine($"Новое число {newNum}");
