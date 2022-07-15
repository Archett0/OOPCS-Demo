namespace Quiz;

public class Photo
{
    public double Width { get; set; }

    public double Height { get; set; }

    protected double price;

    public double Price => price;

    public Photo(double width, double height)
    {
        Width = width;
        Height = height;
        if (Math.Abs(Width - 8) < 1e-6 && Math.Abs(Height - 10) < 1e-6)
        {
            price = 3.99;
        }
        else if (Math.Abs(Width - 10) < 1e-6 && Math.Abs(Height - 12) < 1e-6)
        {
            price = 5.99;
        }
        else
        {
            price = 9.99;
        }
    }

    public override string ToString()
    {
        return "(" + GetType() + ") Width: " + Width + ", Height: " + Height + ", Price: " + Price;
    }
}