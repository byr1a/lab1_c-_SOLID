using System;
using System.Reflection.Metadata.Ecma335;

public class ConsoleInput : IUserInput
{
    public int GetInput()
    {
        return int.Parse(Console.ReadLine());
    }
}