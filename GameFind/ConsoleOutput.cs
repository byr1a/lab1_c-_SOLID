using System;

public class ConsoleOutput : IOutput
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}
