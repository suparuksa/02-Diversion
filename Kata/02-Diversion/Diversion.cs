namespace Kata.Diversion;

using System;

public class Diversion
{
    public int CountDigits(string input)
    {
        return input.Length;
    }

    public int CountNotTwoAdjacentOne(string input)
    {
        if (IsAdjacentOne(input))
            return 0;
        else
            return 1;
    }

    public int CountAllNotTwoAdjacentOne(string input)
    {
        var inputs = Array.ConvertAll(input.Split(','), p => p.Trim());
        var cntNotAdjacetnOne = 0;
        foreach (var inp in inputs)
        {
            cntNotAdjacetnOne += CountNotTwoAdjacentOne(inp);
        }
        return cntNotAdjacetnOne;
    }

    private bool IsAdjacentOne(string input)
    {
        char[] chars = input.ToCharArray();
        return (chars[0] == '1' && chars[1] == '1') || (chars[1] == '1' && chars[2] == '1');
    }
}


