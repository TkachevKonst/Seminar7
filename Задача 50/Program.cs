// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
using System;
using static System.Console;
Clear();
Write("Введите кличество строк:");
int row = int.Parse(ReadLine());
Write("Введите кличество cтолбцов:");
int collums = int.Parse(ReadLine());
Write("Введите номер строки и столбца через пробел:");
string number = ReadLine();
int[] coordinates = GetArr(number);
int[,] matrix = new int[row, collums];
GetArray(matrix, 0, 10);
PrintArray(matrix);
SearchNumber(matrix, coordinates[0], coordinates[1]);

void GetArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}
void PrintArray(int[,] array)
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
int[] GetArr(string arr)
{
    string[] array = arr.Split(" ");
    int[] arr1 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr1[i] = int.Parse(array[i]);
    }
    return arr1;
}
void SearchNumber(int[,] array, int num1, int num2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == num1 && j == num2)
            {
                WriteLine($"Искомое число {array[i, j]}");
                return;
            }
        }

    }
    WriteLine("Такого числа в массиве нет");
    return;
}