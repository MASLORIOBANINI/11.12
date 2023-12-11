using System;

public class MyClass
{
    private int number1;
    private int number2;

    public MyClass()
    {
        number1 = 0;
        number2 = 0;
    }

    public MyClass(int num)
    {
        number1 = num;
        number2 = 0;
    }

    public MyClass(int num1, int num2)
    {
        number1 = num1;
        number2 = num2;
    }

    public void PrintNumbers()
    {
        Console.WriteLine("Number 1: " + number1);
        Console.WriteLine("Number 2: " + number2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(); // Создание объекта без передачи аргументов
        Console.WriteLine("Object 1:");
        obj1.PrintNumbers();

        MyClass obj2 = new MyClass(10); // Создание объекта с передачей одного аргумента
        Console.WriteLine("Object 2:");
        obj2.PrintNumbers();

        MyClass obj3 = new MyClass(20, 30); // Создание объекта с передачей двух аргументов
        Console.WriteLine("Object 3:");
        obj3.PrintNumbers();
    }
}