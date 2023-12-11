using System;

public class MyClass
{
    private char п;

    public void SetSymbol(char value)
    {
        п = value;
    }

    public int GetSymbolCode()
    {
        return (int)п;
    }

    public void PrintSymbolAndCode()
    {
        Console.WriteLine($"Символ: {п}\nКод символа: {(int)п}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        // Присваиваем значение полю "п"
        myObject.SetSymbol('A');

        // Выводим результат выполнения метода GetSymbolCode()
        Console.WriteLine($"Код символа: {myObject.GetSymbolCode()}");

        // Выводим символ и его код с помощью метода PrintSymbolAndCode()
        myObject.PrintSymbolAndCode();
    }
}