using System;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int aWholeNumber)
    {
        _top = aWholeNumber;
    }
    public Fraction (int Nominator, int Denominator)
    {
        _top = Nominator;
        _bottom = Denominator;
    }

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int NewTop)
    {
        _top = NewTop;
    }
    public void SetBottom(int NewBottom)
    {
        _bottom = NewBottom;
    }

    public string GetFractionString()
    {
        return $"{_top} / {_bottom}";

    }
    public double GetDecimal()
    {
        double dec = _top / _bottom;
        return dec;
    }

}