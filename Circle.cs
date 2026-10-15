public class Circle
{
    public double Radius;
    public double PI = 3.14;

    public Circle(double radius)
    {
        Radius = radius;
    }
    public Circle() { }

    public void SetRadius(double radius)
    {
        Radius = radius;
    }

    public double GetRadius()
    {
        return Radius;
    }

    public double GetArea()
    {
        return PI * Radius * Radius;
    }
    public double GetDiametr()
    {
        return Radius * 2;
    }
    public double GetCircumference()
    {
        return 2 * PI * Radius;
    }
}