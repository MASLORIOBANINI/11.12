using System;

public class NumberCounter
{
    private static int count = 0;

    public static void DisplayCount()
    {
        Console.WriteLine("Текущее значение счетчика: " + count);
        count++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        NumberCounter.DisplayCount(); // Выведет: "Текущее значение счетчика: 0"
        NumberCounter.DisplayCount(); // Выведет: "Текущее значение счетчика: 1"
        NumberCounter.DisplayCount(); // Выведет: "Текущее значение счетчика: 2"
    }
}