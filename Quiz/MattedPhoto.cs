namespace Quiz;

public class MattedPhoto: Photo
{
    public string Color { get; set; }

    public MattedPhoto(double width, double height, string color) : base(width, height)
    {
        Color = color;
        price += 10.0;
    }

    public override string ToString()
    {
        return base.ToString() + ", Color: " + Color;
    }
}