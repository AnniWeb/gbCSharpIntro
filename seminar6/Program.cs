// Урок 6. Одномерные массивы. Продолжение
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

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

static int CountPositiveNumbers(int[] array)
{   
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) {
            counter++;
        }
    }

    return counter;
}

static void FindIntersection(double b1, double k1, double b2, double k2, out double xIntersection, out double yIntersection)
{   
    xIntersection = (b2 - b1) / (k1 - k2);
    yIntersection = k1 * xIntersection + b1;
}

{
    Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    int size = GetIntNumberFromUser("Введите целое число M: ", "Ошибка ввода:");
    int[] userArray = new int[size];
    for (int i = 0; i < size; i++) {
        userArray[i] = GetIntNumberFromUser($"Введите элемент {i + 1}: ", "Ошибка ввода:");
    }
    
    int result = CountPositiveNumbers(userArray);
    Console.WriteLine($"{String.Join(" ", userArray)} -> {result}");
}
Console.WriteLine("");

{
    Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
    double b1 = GetDoubleNumberFromUser("Введите число b1: ", "Ошибка ввода:");
    double k1 = GetDoubleNumberFromUser("Введите число k1: ", "Ошибка ввода:");
    double b2 = GetDoubleNumberFromUser("Введите число b2: ", "Ошибка ввода:");
    double k2 = GetDoubleNumberFromUser("Введите число k2: ", "Ошибка ввода:");
    double x,y;
    
    FindIntersection(b1, k1, b2, k2, out x, out y);
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x:F2}; {y:F2})");
}