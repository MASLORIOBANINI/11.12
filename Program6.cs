using System;

public class CharacterText
{
    private char charField;
    private string textField;

    public void SetValue(char value)
    {
        charField = value;
    }

    public void SetValue(string value)
    {
        textField = value;
    }

    public void SetValue(char[] value)
    {
        if (value.Length == 1)
        {
            charField = value[0];
        }
        else
        {
            textField = new string(value);
        }
    }

    public void DisplayValues()
    {
        Console.WriteLine("Char: " + charField);
        Console.WriteLine("Text: " + textField);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CharacterText ct = new CharacterText();
        ct.DisplayValues();

        ct.SetValue('A');
        ct.DisplayValues();

        ct.SetValue("Hello");
        ct.DisplayValues();

        char[] charArray = { 'B', 'C', 'D' };
        ct.SetValue(charArray);
        ct.DisplayValues();
    }
}