namespace DNDA_Aufgaben;

public class WarmUpLoesungen
{
    public int SumDouble(int a, int b)
    {
        if (a == b)
        {
            return (a + b) * 2;
        }

        return a + b;
    }

    public bool CanSleep(bool weekday, bool vacation)
    {
        return !weekday || vacation;
    }

    public bool IsBetween10and20(int a, int b)
    {
        bool aIsBetween10and20 = a >= 10 && a <= 20;
        bool bIsBetween10and20 = b >= 10 && b <= 20;

        return aIsBetween10and20 || bIsBetween10and20;
    }

    public bool StartsWithHi(string s)
    {
        if (s.Length < 2)
            return false;
        
        var firstTwoLetters = s.Substring(0, 2);
        
        return firstTwoLetters.Equals("hi");
    }
}