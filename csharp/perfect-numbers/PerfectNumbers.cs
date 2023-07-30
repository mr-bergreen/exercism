using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0) throw new ArgumentOutOfRangeException();

        var factors = new ArrayList();
        int sum = 0;

        for (int i = 1; i <= number / 2; i++) 
        { 
            if (number % i == 0)
            {
                factors.Add(i);
                sum += i;
            }
        }

        switch (sum)
        {
            case int when sum == number:
                return Classification.Perfect;

            case int when sum > number:
                return Classification.Abundant;

            default:
                return Classification.Deficient;
        }
    }
}
