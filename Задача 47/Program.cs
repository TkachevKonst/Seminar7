//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System;
using static System.Console;
Clear();
Write("Введите кличество строк:");
int row = int.Parse(ReadLine());
Write("Введите кличество cтолбцов:");
int collums = int.Parse(ReadLine());
double[,] matrix = new double[row, collums];
GetArray(matrix, 0, 10);
PrintArray(matrix);


void GetArray(double[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1) + new Random().NextDouble();
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($" {array[i, j]:f2}");
        }
        WriteLine();
    }
}

