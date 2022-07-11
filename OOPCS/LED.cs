namespace OOPCS;

public class LED
{
    private string Color { get; set; }
    private bool IsOn { get; set; }

    public LED(string color)
    {
        Color = color;
        IsOn = false;
    }

    public string GetColor()
    {
        return Color;
    }

    public bool IsLEDOn()
    {
        if (IsOn)
        {
            Console.WriteLine("LED ON");
            return true;
        }
        else
        {
            Console.WriteLine("LED OFF");
            return false;
        }
    }

    public void TurnOn()
    {
        if (!IsOn)
        {
            IsOn = true;
        }
    }

    public void TurnOff()
    {
        if (IsOn)
        {
            IsOn = false;
        }
    }
}