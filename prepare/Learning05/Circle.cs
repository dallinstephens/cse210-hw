public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
        : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        // Reference for pi:
        // http://www.java2s.com/Tutorials/CSharp/System/Math/C_Math_PI.htm
        // Reference for exponent:
        // https://www.tutorialspoint.com/math-pow-method-in-chash
        return Math.PI * Math.Pow(_radius, 2);
    }
}