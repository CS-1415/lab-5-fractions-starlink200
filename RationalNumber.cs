using System.Collections;
using System.ComponentModel;
using Microsoft.VisualBasic;

public class RationalNumber
{
    public readonly int Numerator;
    public readonly int Denominator;

    public RationalNumber()
    {

    }
    public RationalNumber(int _numerator, int _denominator)
    {
        Numerator = _numerator / GreatestCommonDenominator(_numerator, _denominator);
        Denominator = _denominator / GreatestCommonDenominator(_numerator, _denominator);
    }

    static int GreatestCommonDenominator(int a, int b)
    {
        if (b == 0)
        {
            return Math.Abs(a);
        }
        else { return GreatestCommonDenominator(b, a % b); }
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

}