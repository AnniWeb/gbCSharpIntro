/**
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
{
    Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.Write("Введите целое число: ");
    int number, result;
    if (Int32.TryParse(Console.ReadLine(), out number)) {
        if (number >= 1000 || number < 100) {
            Console.WriteLine("Ошибка: должно быть введено трехзначное положительное число");
        } else {
            result = number / 10 % 10;
            Console.WriteLine($"{number} -> {result}");
        }
    } else {
        Console.WriteLine("Ошибка: некорректный формат ввода");
    }
}
Console.WriteLine("");

/**
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
{
    Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    int number, result;
    Console.Write("Введите целое число: ");
    if (Int32.TryParse(Console.ReadLine(), out number)) {
        bool sing = number >= 0;
        number = sing ? number : -number;
        if (number < 100 && number >= 0) {
            number = sing ? number : -number;
            Console.WriteLine($"{number} -> третьей цифры нет");
        } else {
            result = number;
            while (result >= 1000)
            {
                result /= 10;
            }
            result %= 10;
            number = sing ? number : -number;
            Console.WriteLine($"{number} -> {result}");
        }
    } else {
        Console.WriteLine("Ошибка: некорректный формат ввода");
    }
}
Console.WriteLine("");

/**
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
{
    Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    Console.Write("Введите день недели (число в диапозоне 1-7): ");
    int dayNumber;
    if (Int32.TryParse(Console.ReadLine(), out dayNumber)) {
        if (dayNumber < 1 || dayNumber > 7) {
            Console.WriteLine("Ошибка: число должно быть в диапозоне 1-7");
        } else {
            string result = dayNumber >= 6 ? "да" : "нет";
            Console.WriteLine($"{dayNumber} -> {result}");
        }
    } else {
        Console.WriteLine("Ошибка: некорректный формат ввода");
    }

}