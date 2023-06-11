//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите колличество строк в двумерном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов в двумерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];

void GenerateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}

void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        double Result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Result += array[i, j];
        }
        Console.Write($"{Result / array.GetLength(0)}; ");
    }
}

GenerateRandomArray(numbers);
PrintRandomArray(numbers);
Console.WriteLine($"");
ArithmeticMean(numbers);