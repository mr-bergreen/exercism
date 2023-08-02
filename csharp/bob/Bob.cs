using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (string.IsNullOrEmpty(statement)) 
        {
            return "Fine. Be that way!"; 
        }
        else if (HasLetters(statement) && IsAllCaps(statement))
        {
            if (statement.EndsWith("?"))
            {
                return "Calm down, I know what I'm doing!";
            }
            else
            {
                return "Whoa, chill out!";
            }
        }
        else if (statement.EndsWith("?"))
        {
            return "Sure.";
        }
        return "Whatever.";
    }

    public static bool IsAllCaps(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]) && !char.IsUpper(s[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static bool HasLetters(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                return true;
            }
        }
        return false;
    }
}