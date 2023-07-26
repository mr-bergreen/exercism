using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;

        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        foreach(char c in alphabet)
        {
            char upper = char.ToUpper(c);
            char lower = char.ToLower(c);
            if (!input.Contains(upper) && !input.Contains(lower)) return false;
        }
        return true;
    }
}
