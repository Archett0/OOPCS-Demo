namespace Exercise;
/**
 * TODO: implement class Triangle
 *
 * 1. This class has 3 auto-properties: Side1, 
 * Side2, Side3 all in double. 
 * 
 * 2. It has one constructor that accepts 3 
 * double values and set them to its 3 sides. 
 * This constructor throws a bad triangle exception
 * with message "Invalid sides" if the given 3
 * sides do not represent a valid triangle
 * 
 * 3. The class also has methods Perimeter() 
 * and Area() that compute the perimeter and 
 * area of the triangle.
 */

public class Triangle
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public Triangle(double side1, double side2, double side3)
    {
        if (IsValidTriangle(side1, side2, side3))
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        else
        {
            throw new BadTriangleException("Invalid sides");
        }
    }

    public double Perimeter()
    {
        return Side1 + Side2 + Side3;
    }

    public double Area()
    {
        var p = Perimeter() / 2.0;
        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }

    // Use the following logic if you need
    private static bool IsValidTriangle(double side1, double side2, double side3)
    {
       return side1 > 0 && side2 > 0 && side3 > 0 && 
          side1 + side2 > side3 && 
          side1 + side3 > side2 && 
          side2 + side3 > side1;
    }

    public override string ToString()
    {
        return "Perimeter: " + Perimeter() + ", Area: " + Area();
    }
}