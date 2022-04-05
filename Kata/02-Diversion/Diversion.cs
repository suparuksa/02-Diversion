namespace Kata.Diversion;

public class Diversion
{
    public int CountNotTwoAdjacentOne(string input)
    {
        char[] chars = input.ToCharArray();
        if ((chars[1] == '1' && chars[2] == '1'))
            return 0;
        else
            return 1;
    }
}

