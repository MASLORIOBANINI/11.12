using System;

public class CharacterClass
{
    private char startChar;
    private char endChar;

    public void SetStartChar(char start)
    {
        startChar = start;
    }

    public void SetEndChar(char end)
    {
        endChar = end;
    }

    public void PrintCharacters()
    {
        int startCode = (int)startChar;
        int endCode = (int)endChar;

        for (int i = startCode; i <= endCode; i++)
        {
            char currentChar = (char)i;
            Console.Write(currentChar + " ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CharacterClass myObject = new CharacterClass();

        myObject.SetStartChar('A');
        myObject.SetEndChar('D');

        myObject.PrintCharacters();
    }
}