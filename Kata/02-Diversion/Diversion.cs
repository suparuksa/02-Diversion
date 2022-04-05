namespace Kata.Diversion;

public class Diversion
{
    public int CountNotTwoAdjacentOne(string input)
    {
        if (IsAdjacentOne(input))
            return 0;
        else
            return 1;
    }

    public int CountAllNotTwoAdjacentOne(string input)
    {
        return 0;
    }

    private bool IsAdjacentOne(string input)
    {
        char[] chars = input.ToCharArray();
        return (chars[0] == '1' && chars[1] == '1') || (chars[1] == '1' && chars[2] == '1');
    }
}


