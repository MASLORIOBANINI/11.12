using System;

public class MyClass
{
    private char charField;
    private int intField;

    public MyClass(int intValue, char charValue)
    {
        intField = intValue;
        charField = charValue;
    }

    public MyClass(double doubleValue)
    {
        intField = (int)(doubleValue % 1 * 100);
        charField = (char)(int)(doubleValue);
    }

    public void PrintValues()
    {
        Console.WriteLine("Символьное поле: " + charField);
        Console.WriteLine("Целочисленное поле: " + intField);
    }
}

public class Program
{
    public static void Main()
    {
        MyClass obj1 = new MyClass(12, 'A');
        obj1.PrintValues();

        Console.WriteLine();

        MyClass obj2 = new MyClass(65.1267);
        obj2.PrintValues();
    }
}