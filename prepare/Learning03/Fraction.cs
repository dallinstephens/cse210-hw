public class Fraction
{
    private int _top; // numerator
    private int _bottom; // denominator

    public Fraction()
    {
        // Default is 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        // Reference to get a double when dividing two integers:
        // https://stackoverflow.com/questions/661028/how-can-i-divide-two-integers-to-get-a-double
        return (double)_top / _bottom;
    }

    // NOTE: AVOID USING GETTERS AND SETTERS. THEY WERE NOT NECESSARY WHEN USING THE CONSTRUCTORS.

    // public int GetTop()
    // {
    //     return _top;
    // }

    // public void SetTop(int top)
    // {
    //     _top = top;
    // }

    // public int GetBottom()
    // {
    //     return _bottom;
    // }

    // public void SetBottom(int bottom)
    // {
    //     _bottom = bottom;
    // }    

}