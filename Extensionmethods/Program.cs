using System;
using Course.Extensions;

public class ProcessFile
{
    public static void Main()
    {
        string s1 = "Good morning dear students!";
        Console.WriteLine(s1.Cut(10));
    }
}