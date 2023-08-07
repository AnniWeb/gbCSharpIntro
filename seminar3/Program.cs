// Определяем функцию, выполняющую ввод целого числа с консоли
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

static double getDistanceIn3D(int aX, int aY, int aZ, int bX, int bY, int bZ)
{
    return Math.Sqrt(Math.Pow((bY - aY), 2) + Math.Pow((bX - aX), 2) + Math.Pow((bZ - aZ), 2));
}


/**
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
{
    Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    int number = GetIntNumberFromUser("Введите целое число: ", "Ошибка ввода:");

    if (number >= 10000 && number < 100000) {
        int num1 = number / 10000;
        int num2 = number / 1000 % 10;
        int num3 = number / 100 % 10;
        int num4 = number / 10 % 10;
        int num5 = number % 10;
        if (num1 == num5 && num2 == num4) {
            Console.WriteLine($"{number} -> да");
        } else {
            Console.WriteLine($"{number} -> нет");
        }
    } else {
        Console.WriteLine("Ошибка: должно быть введено пятизначное положительное число");
    }
}
Console.WriteLine("");

/**
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
{
    Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

    #region --- Ввод переменных
    int aX = GetIntNumberFromUser("Введите A[x]: ", "Ошибка ввода A[x]:");
    int aY = GetIntNumberFromUser("Введите A[y]: ", "Ошибка ввода A[y]:");
    int aZ = GetIntNumberFromUser("Введите A[z]: ", "Ошибка ввода A[z]:");
    int bX = GetIntNumberFromUser("Введите B[x]: ", "Ошибка ввода B[x]:");
    int bY = GetIntNumberFromUser("Введите B[y]: ", "Ошибка ввода B[y]:");
    int bZ = GetIntNumberFromUser("Введите B[z]: ", "Ошибка ввода B[z]:");
    #endregion

    #region --- Рассчет
    double result = getDistanceIn3D(aX, aY, aZ, bX, bY, bZ);
    #endregion

    #region --- Результат
    Console.WriteLine($"A ({aX},{aY}, {aZ}); B ({bX},{bY}, {bZ}) -> {result}");
    #endregion
}
Console.WriteLine("");

/**
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
{
    Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    int size = GetIntNumberFromUser("Введите N: ", "Ошибка ввода N:");

    Console.Write($"{size} ->");
    if (size == 0) {
        Console.Write(" ");
    } else if (size < 0) {
        for(int i = size; i < 0; i++) {
            int result = (int) Math.Pow(i, 3);
            Console.Write($" {result},");
        }
    } else {
        for(int i = 1; i <= size; i++) {
            int result = (int) Math.Pow(i, 3);
            Console.Write($" {result},");
        }
    }
    Console.WriteLine("");
}