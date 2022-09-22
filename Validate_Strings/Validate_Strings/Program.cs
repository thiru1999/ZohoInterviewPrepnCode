using System;
using System.Linq;
class ValidateString
{
    public bool Validate(string s)
    {
        return s.All(char.IsUpper);

    }
    public static bool PasswordComplex(string s)
    {
        return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);

    }
    public static string Normalise(String s)
    {
        return s.ToLower().Trim().Replace(",", " ");

    }
    public static void Main()
    {
        Console.WriteLine(PasswordComplex("Hello1"));
        Console.WriteLine(PasswordComplex("Hello"));
        Console.WriteLine(Normalise("Hello,Hi there Buddy,Hello,Welcome"));

    }
}