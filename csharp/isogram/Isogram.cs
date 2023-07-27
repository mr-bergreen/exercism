using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string letters = "";

        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                if (letters.Contains(char.ToLower(c)))
                {
                    return false;
                }
                letters += char.ToLower(c);
            }
        }

        return true;
    }
}
