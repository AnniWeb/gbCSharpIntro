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

static double GetDoubleNumberFromUser(string message, string errorMessage)
{   
    while(true)
    {
        try
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine() ?? "");            
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");        
        }
    }
}

static void PrintNaturalNumbers(int n)
{
    if (n <= 0)
    {
        return;
    }

    Console.Write(n);

    if (n > 1)
    {
        Console.Write(", ");
    }

    PrintNaturalNumbers(n - 1);
}
static int CalculateSum(int m, int n)
{
    int sum = 0;

    for (int i = m; i <= n; i++)
    {
        sum += i;
    }

    return sum;
}
static int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else
    {
        throw new ArgumentException("Функция Аккермана определена только для неотрицательных целых чисел.");
    }
}
/**
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
{
    Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
    int n = GetIntNumberFromUser("Введите целое число N: ", "Ошибка ввода:");

    Console.Write($"N = {n} -> ");
    PrintNaturalNumbers(n);
    Console.WriteLine("");
}
Console.WriteLine("");

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
{
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    int m = GetIntNumberFromUser("Введите целое число M: ", "Ошибка ввода:");
    int n = GetIntNumberFromUser("Введите целое число N: ", "Ошибка ввода:");
    int result = CalculateSum(m, n);

    Console.WriteLine($"M = {m}; N = {n}. -> {result}");
}
Console.WriteLine("");

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
{
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    int m = GetIntNumberFromUser("Введите целое число M: ", "Ошибка ввода:");
    int n = GetIntNumberFromUser("Введите целое число N: ", "Ошибка ввода:");
    int result = AckermannFunction(m, n);

    Console.WriteLine($"M = {n}; N = {m}. -> A(m,n) = {result}");
}
Console.WriteLine("");