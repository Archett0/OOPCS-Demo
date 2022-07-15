namespace Quiz;

public class FramedPhoto: Photo
{
    public string Material { get; set; }
    public string Style { get; set; }

    public FramedPhoto(double width, double height, string material, string style) : base(width, height)
    {
        Material = material;
        Style = style;
        price += 25.0;
    }

    public override string ToString()
    {
        return base.ToString() + ", Material: " + Material + ", Style: " + Style;
    }
}