using System;

public class NumberRange
{
    private int max;
    private int min;

    public NumberRange()
    {
        max = 0;
        min = 0;
    }

    public NumberRange(int value)
    {
        max = value;
        min = value;
    }

    public NumberRange(int value1, int value2)
    {
        max = Math.Max(value1, value2);
        min = Math.Min(value1, value2);
    }

    public void SetValues(int value)
    {
        max = Math.Max(value, max);
        min = Math.Min(value, min);
    }

    public void SetValues(int value1, int value2)
    {
        max = Math.Max(value1, value2);
        min = Math.Min(value1, value2);
    }

    public void DisplayValues()
    {
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
    }
}

class Program
{
    static void Main(string[] args)
    {
        NumberRange range = new NumberRange();
        range.DisplayValues();

        range.SetValues(10);
        range.DisplayValues();

        range.SetValues(5, 15);
        range.DisplayValues();
    }
}