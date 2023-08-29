/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

static double[,] GenerateRandomMatrix(int rows, int columns)
    {
        Random random = new Random((int) DateTime.Now.Ticks);
        double[,] matrix = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = (random.NextDouble() - 0.5) * 200.0;
            }
        }

        return matrix;
    }


static int GetIntNumberFromUser(string message, string errorMessage)
{   
    while(true)
    {
        try
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine() ?? "");            
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");        
        }
    }
}

static double GetElementFromArray(double[,] matrix, int row, int col)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    if (row >= 0 && row < numRows && col >= 0 && col < numCols)
    {
        return matrix[row, col];
    }
    else
    {
        return double.NaN;
    }
}

static double[] GetColumnAverages(double[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    double[] columnAverages = new double[numCols];

    for (int col = 0; col < numCols; col++)
    {
        double sum = 0.0; 
        for (int row = 0; row < numRows; row++)
        {
            sum += matrix[row, col];
        }
        columnAverages[col] = sum / numRows;
    }

    return columnAverages;
}

{
    Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
    int rows = GetIntNumberFromUser("Введите размерность m: ", "Ошибка ввода:");
    int columns = GetIntNumberFromUser("Введите размерность n: ", "Ошибка ввода:");
    double[,] matrix = GenerateRandomMatrix(rows, columns);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],8:F2}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("");

{
    Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    int rows = GetIntNumberFromUser("Введите размерность m: ", "Ошибка ввода:");
    int columns = GetIntNumberFromUser("Введите размерность n: ", "Ошибка ввода:");
    int row = GetIntNumberFromUser("Введите номер столбеца: ", "Ошибка ввода:");
    int col = GetIntNumberFromUser("Введите номер строки: ", "Ошибка ввода:");

    double[,] matrix = GenerateRandomMatrix(rows, columns);
    double result = GetElementFromArray(matrix, row, col);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],8:F2}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    if (double.IsNaN(result)) {
        Console.WriteLine($"{row} {col} -> такого числа в массиве нет");   
    } else {
        Console.WriteLine($"{row} {col} -> {result}");   
    }
}
Console.WriteLine("");

{
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    int rows = GetIntNumberFromUser("Введите размерность m: ", "Ошибка ввода:");
    int columns = GetIntNumberFromUser("Введите размерность n: ", "Ошибка ввода:");

    double[,] matrix = GenerateRandomMatrix(rows, columns);
    double[] result = GetColumnAverages(matrix);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],8:F2}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join(" ", result)}");
}
Console.WriteLine("");