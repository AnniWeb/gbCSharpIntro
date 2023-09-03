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

static void PrintMatrix(int[,] matrix, string format = null)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            string formattedNumber = format != null ? string.Format(format, matrix[i, j]) : matrix[i, j].ToString();
            Console.Write(formattedNumber + " ");
        }
        Console.WriteLine();
    }
}

static void SortRowsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

static int FindRowWithMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int minSumRow = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSum += array[i, j];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRow = i;
        }
    }

    return minSumRow;
}

static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    if (cols1 != rows2)
    {
        throw new ArgumentException("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
    }

    int[,] resultMatrix = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}

static int[,,] GenerateThreeDimArray(int xSize, int ySize, int zSize)
    {
        if (xSize * ySize * zSize > 90)
        {
            throw new ArgumentException("Невозможно сгенерировать массив с уникальными двузначными числами.");
        }

        Random random = new Random();
        int[,,] array = new int[xSize, ySize, zSize];
        int[] uniqueNumbers = new int[90];

        for (int i = 0; i < 90; i++)
        {
            uniqueNumbers[i] = i + 10; // Двузначные числа от 10 до 99
        }

        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {
                for (int z = 0; z < zSize; z++)
                {
                    int randomIndex = random.Next(uniqueNumbers.Length);
                    array[x, y, z] = uniqueNumbers[randomIndex];
                    uniqueNumbers[randomIndex] = uniqueNumbers[uniqueNumbers.Length - 1];
                    Array.Resize(ref uniqueNumbers, uniqueNumbers.Length - 1);
                }
            }
        }

        return array;
    }

static int[,] FillSpiralArray(int rows, int cols)
{
    int[,] result = new int[rows, cols];
    int currentValue = 1;
    int top = 0;
    int bottom = rows - 1;
    int left = 0;
    int right = cols - 1;

    while (currentValue <= rows * cols)
    {
        for (int i = left; i <= right; i++)
        {
            result[top, i] = currentValue++;
        }
        top++;

        for (int i = top; i <= bottom; i++)
        {
            result[i, right] = currentValue++;
        }
        right--;

        for (int i = right; i >= left; i--)
        {
            result[bottom, i] = currentValue++;
        }
        bottom--;

        for (int i = bottom; i >= top; i--)
        {
            result[i, left] = currentValue++;
        }
        left++;
    }

    return result;
}

static int[,] GenerateRandomMatrix(int rows, int columns)
    {
        Random random = new Random((int) DateTime.Now.Ticks);
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(1, 100);
            }
        }

        return matrix;
    }
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
{
    Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

    int rows = GetIntNumberFromUser("Введите размерность m: ", "Ошибка ввода:");
    int columns = GetIntNumberFromUser("Введите размерность n: ", "Ошибка ввода:");
    int[,] array = GenerateRandomMatrix(rows, columns);

    Console.WriteLine("Первоначальная матрица:");
    PrintMatrix(array, "{0:D2}");

    SortRowsDescending(array);

    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(array, "{0:D2}");
}
Console.WriteLine("");


/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
{
    Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

    int rows = GetIntNumberFromUser("Введите размерность m: ", "Ошибка ввода:");
    int columns = GetIntNumberFromUser("Введите размерность n: ", "Ошибка ввода:");
    int[,] array = GenerateRandomMatrix(rows, columns);

    int minSumRow = FindRowWithMinSum(array);

    PrintMatrix(array, "{0:D2}");
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1} строка");
}
Console.WriteLine("");

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
{
    Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

    int rows1 = GetIntNumberFromUser("Введите размерность m для матрицы 1: ", "Ошибка ввода:");
    int columns1 = GetIntNumberFromUser("Введите размерность n для матрицы 1: ", "Ошибка ввода:");
    int[,] matrix1 = GenerateRandomMatrix(rows1, columns1);

    int rows2 = GetIntNumberFromUser("Введите размерность m для матрицы 2: ", "Ошибка ввода:");
    int columns2 = GetIntNumberFromUser("Введите размерность n для матрицы 2: ", "Ошибка ввода:");
    int[,] matrix2 = GenerateRandomMatrix(rows2, columns2);

    int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

    Console.WriteLine("Матрица 1:");
    PrintMatrix(matrix1, "{0:D2}");
    Console.WriteLine("Матрица 2:");
    PrintMatrix(matrix2, "{0:D2}");
    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(resultMatrix, "{0:D2}");
}
Console.WriteLine("");

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
{
    Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

    int sizeX = 2;
    int sizeY = 2;
    int sizeZ = 2;

    int[,,] threeDimArray = GenerateThreeDimArray(sizeX, sizeY, sizeZ);

    // Вывод трехмерного массива с индексами
    for (int x = 0; x < sizeX; x++)
    {
        for (int y = 0; y < sizeY; y++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                Console.WriteLine($"{threeDimArray[x, y, z]}({x},{y},{z})");
            }
        }
    }
}
Console.WriteLine("");

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
{
    Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");

    int size = 4;
    int[,] spiralArray = FillSpiralArray(size, size);
    PrintMatrix(spiralArray, "{0:D2}");
}