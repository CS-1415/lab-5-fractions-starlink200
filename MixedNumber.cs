public class MixedNumber
{
    public int _Numerator;
    public int _Denominator;

    public readonly int WholeNumber;
    public readonly RationalNumber PartialUnits;

    public MixedNumber(int numerator, int denominator)
    {
        new MixedNumber(new RationalNumber(numerator, denominator));
    }

    public MixedNumber(RationalNumber rationalNumber)
    {

    }
}