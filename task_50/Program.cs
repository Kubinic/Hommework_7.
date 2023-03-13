/*Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;
using static System.Console;
int answer = 0;
Write("Введите позиции элемента по горизонтали: ");
int horizontal =int.Parse(ReadLine());
Write("Введите позиции элемента по вертикали : ");
int vertical=int.Parse(ReadLine());
int [,]array = GetArray(5, 5);
PrintArray(array);
digit_by_array_index(array, horizontal, vertical);
int[,] GetArray(int m, int n, int minValue = 1, int maxValue = 100)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
void digit_by_array_index(int [,] array,int horizontal, int vertical){
if (array.GetLength(0) >= horizontal && array.GetLength(1) >= vertical)
{
    answer = array[horizontal-1, vertical-1];
    WriteLine($"Ваше число {answer}");
}
else
    WriteLine("Элемента с таким индексом нет");
}