using System;

public class MyClass
{
    private int intValue;

    public MyClass()
    {
        intValue = 0;
    }

    public MyClass(int value)
    {
        if (value > 100)
        {
            intValue = 100;
        }
        else
        {
            intValue = value;
        }
    }

    public void SetValue(int value)
    {
        if (value > 100)
        {
            intValue = 100;
        }
        else
        {
            intValue = value;
        }
    }

    public int GetValue()
    {
        return intValue;
    }
}

public class Program
{
    public static void Main()
    {
        MyClass obj1 = new MyClass();
        Console.WriteLine("Значение поля после вызова конструктора без аргументов: " + obj1.GetValue());

        Console.WriteLine();

        MyClass obj2 = new MyClass(150);
        Console.WriteLine("Значение поля после вызова конструктора с аргументом 150: " + obj2.GetValue());

        Console.WriteLine();

        obj1.SetValue(75);
        Console.WriteLine("Значение поля после вызова метода SetValue с аргументом 75: " + obj1.GetValue());
    }
}