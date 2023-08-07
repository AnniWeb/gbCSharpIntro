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

static int[] RandomPositiveArray(int size) {
    int[] array = new int[size];
    Random rnd = new Random((int) DateTime.Now.Ticks);
    for (int i = 0; i < size; i++) {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

static int[] RandomArray(int size) {
    int[] array = new int[size];
    Random rnd = new Random((int) DateTime.Now.Ticks);
    for (int i = 0; i < size; i++) {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}

static int CountEventElements(int[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++) {
        result += array[i] % 2 == 0 ? 1 : 0;
    }
    return result;
}

static int SumByOddPos(int[] array) {
    int result = 0;
    for (int i = 1; i < array.Length; i += 2) {
        result += array[i];
    }
    return result;
}

static double GetDiff(double[] array) {
    if (array.Length == 0) {
        throw new RankException("Массив не должен быть пустым");
    }
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i ++) {
        if (array[i] > max) {
            max = array[i];
        }
        if (array[i] < min) {
            min = array[i];
        }
    }
    return max - min;
}

{
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    int size = GetIntNumberFromUser("Введите размерность: ", "Ошибка ввода:");
    int[] array = RandomPositiveArray(size);
    int result = CountEventElements(array);
    Console.WriteLine($"[{String.Join(" ", array)}] -> {result}");
}
Console.WriteLine("");

{
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    int size = GetIntNumberFromUser("Введите размерность: ", "Ошибка ввода:");
    int[] array = RandomArray(size);
    int result = SumByOddPos(array);
    Console.WriteLine($"[{String.Join(" ", array)}] -> {result}");
}
Console.WriteLine("");

{
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    int size = GetIntNumberFromUser("Введите размерность: ", "Ошибка ввода:");

    double[] array = new double[size];
    for (int i = 0; i < size; i++) {
        array[i] = GetDoubleNumberFromUser($"Введите элемент {i + 1}: ", "Ошибка ввода:");
    }

    double result = GetDiff(array);
    Console.WriteLine($"[{String.Join(" ", array)}] -> {Math.Round(result, 2)}");
}
Console.WriteLine("");