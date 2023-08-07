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

static int NatPow(int a, int b)
{
    if (a <= 0) {
        throw new ArgumentOutOfRangeException("Число a должно быть натуральным");
    }
    if (b <= 0) {
        throw new ArgumentOutOfRangeException("Число b должно быть натуральным");
    }
    int result = a;
    for(int i = 2; i <= b; i++) {
        result *= a;
    }
    return result;
}

static int SumNumbers(int number) 
{
    if (number < 0) {
        throw new ArgumentOutOfRangeException("Число должно больше либо равно 0");
    }
    int result = 0;
    int tmp = number;
    while (tmp > 10) {
        result += tmp % 10;
        tmp /= 10;
    }

    if (tmp != 10) {
        result += tmp;
    }

    return result;
}

static string ArrayToString(int[] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++) {
        if (i > 0) {
            result += ", ";
        }
        result += Convert.ToString(array[i]);
    }

    return result;
}

{
    Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
    int a = GetIntNumberFromUser("Введите целое число a: ", "Ошибка ввода:");
    int b = GetIntNumberFromUser("Введите целое число b: ", "Ошибка ввода:");
    int result = NatPow(a, b);
    Console.WriteLine($"{a}, {b} -> {result}");
}
Console.WriteLine("");

{
    Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
    int a = GetIntNumberFromUser("Введите целое число: ", "Ошибка ввода:");
    int result = SumNumbers(a);
    Console.WriteLine($"{a} -> {result}");
}
Console.WriteLine("");

{
    Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
    int size = GetIntNumberFromUser("Введите размерность: ", "Ошибка ввода:");
    int[] a = new int[size];
    for (int i = 0; i < size; i++) {
        a[i] = GetIntNumberFromUser($"Введите элемент {i + 1}: ", "Ошибка ввода:");
    }
    string result = ArrayToString(a);
    Console.WriteLine($"{String.Join(" ", a)} -> [{result}]");
}