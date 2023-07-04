//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using System;
using static System.Console;
Clear();
Write("Введите кличество строк:");
int row = int.Parse(ReadLine());
Write("Введите кличество cтолбцов:");
int collums = int.Parse(ReadLine());
double[,] matrix = new double[row, collums];
GetArray(matrix, 0, 8);
PrintArray(matrix);
ArithmeticMean(matrix);

void GetArray(double[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($" {array[i, j]}");
        }
        WriteLine();
    }
}
void ArithmeticMean(double[,] array)
{
    double mean = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            mean = sum / array.GetLength(0);
        }
        WriteLine($"Сумма в столбце {j + 1} = {sum}");
        WriteLine($"Среднее арифметическое элементов в столбце {j + 1} = {mean:f1}");
    }
}
