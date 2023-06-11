//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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
            array[i, j] = new Random().Next(-100, 100);
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
GenerateRandomArray(numbers);
PrintRandomArray(numbers);

Console.Write("Введите номер строки в двумерном массиве: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца в двумерном массиве: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Position(int[,] array, int row, int col)
{
    if (row > array.GetLength(0) || col > array.GetLength(1))
    {
        Console.Write("Такого числа в массиве нет");
    }
    else
    {
        Console.Write($"Значение элемента в строке {row} в столбце {col} равно {array[row, col]}");
    }
}
Position(numbers, num1, num2);