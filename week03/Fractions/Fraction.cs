using System.Runtime.CompilerServices;

public class Fraction
{
    // declaring member variables
    private int _top;
    private int _bottom;

    // constructors:
    // 1. Does not require any information
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;

    }

    // gives values for both top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }

    public int GetTopNumber()
    {
        return _top;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }

    public void SetTopNumber(int top)
    {
        _top = top;
    }

    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractiontring()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimal()
    {
        return (double)_top / _bottom;
    }
}