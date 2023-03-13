/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
int a = 5; //new Random().Next(1,10);
int b = 3; //new Random().Next(1,10);
int [,]array = GetArray(a, b);
PrintArray(array);
arithmetic_average_of_array(array);
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
void arithmetic_average_of_array(int[,] array){
    double sum = 0;
    int count = 0;
    int l= 0;
    int j = 0;
    for (int i = 0; count <= array.GetLength(1); count++)
    {   l = 0;
        i = 0;
        sum = 0;
        for ( j= 0; l < array.GetLength(0); i++)
        {
            j = count;
        sum+= array[i, j];       
        l++;
       
        }
        
        j++;
        i = count;
       
     Console.WriteLine($"Среднее арифметическое элементов В столбце {count+1} : {Math.Round((sum / array.GetLength(0) ), 2)}  ");
    }
    }