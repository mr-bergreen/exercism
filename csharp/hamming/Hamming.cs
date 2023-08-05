using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (string.IsNullOrEmpty(firstStrand) && string.IsNullOrEmpty(secondStrand))
        {
            return 0;
        }
        else if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException();
        }
        else
        {
            int count = 0;
            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                {
                    count++;
                }
            }
            return count;
        }
            
    }
}