{
    Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.Write("Введите целое число: ");
    string a = Console.ReadLine() ?? "";
    Console.Write("Введите целое число: ");
    string b = Console.ReadLine() ?? "";
    int number1 = int.Parse(a);
    int number2 = int.Parse(b);
    int max = number1 > number2 ? number1 : number2;
    Console.WriteLine($"a = {number1}; b = {number2} -> max = {max}");
}
Console.WriteLine("");

Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
{
    Console.Write("Введите целое число: ");
    string a = Console.ReadLine() ?? "";
    Console.Write("Введите целое число: ");
    string b = Console.ReadLine() ?? "";
    Console.Write("Введите целое число: ");
    string c = Console.ReadLine() ?? "";
    int number1 = int.Parse(a);
    int number2 = int.Parse(b);
    int number3 = int.Parse(c);
    int max = number1 > number2 ? number1 : number2;
    max = max > number3 ? max : number3;
    Console.WriteLine($"a = {number1}; b = {number2}; c = {number3} -> max = {max}");
}

Console.WriteLine("");
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
{

    Console.Write("Введите целое число: ");
    string a = Console.ReadLine() ?? "";
    int number1 = int.Parse(a);
    string answer = number1 % 2 == 1 ? "Нечетное" : "Четное";
    Console.WriteLine($"a = {number1}-> {answer}");
}

Console.WriteLine("");
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
{
    Console.Write("Введите целое число N: ");
    string n = Console.ReadLine() ?? "";
    int number = int.Parse(n);
    
    Console.Write($"{number} ->");
    if (number > 0){
        for (int i = 0; i <= number; i++) {
            if (i % 2 == 1) {
                Console.Write($" {i}");   
            }
        }
    } else {
        Console.Write(" Нет подходящих положительных чисел");  
    }
    Console.WriteLine("");
}


