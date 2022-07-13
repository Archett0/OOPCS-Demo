namespace Exercise;

public enum Colors
{
    Red,
    Green,
    Blue
}

public class Lamp
{

    public Colors Color { get; set; }
    public bool Status { get; set; }

    public Lamp()
    {
        Color = Colors.Blue;
        Status = false;
    }

    public void TurnOn()
    {
        if (Status)
        {
            Console.WriteLine("\n>>> THE LAMP IS ALREADY ON <<<\n");
        }
        else
        {
            SwitchColor();
            Status = true;
            Console.WriteLine("\n>>> THE LAMP IS ON NOW <<<\n");
        }
    }

    public void TurnOff()
    {
        if (Status)
        {
            Status = false;
            Console.WriteLine("\n>>> THE LAMP IS OFF NOW <<<\n");
        }
        else
        {
            Console.WriteLine("\n>>> THE LAMP IS ALREADY OFF <<<\n");
        }
    }

    public void SwitchColor()
    {
        Color = Color switch
        {
            Colors.Red => Colors.Green,
            Colors.Green => Colors.Blue,
            _ => Colors.Red
        };
    }

    public void ShowColor()
    {
        if (Status)
        {
            Console.WriteLine("\n>>> THE COLOR IS " + Color + " <<<\n");
        }
        else
        {
            Console.WriteLine("\n>>> THE LIGHT IS NOT ON <<<\n");
        }
    }

    public void IsOn()
    {
        Console.WriteLine(
            Status
            ? "\n>>> THE LAMP IS ON <<<\n"
            : "\n>>> THE LAMP IS OFF <<<\n");
    }

    public void ShowMenu()
    {
        Console.WriteLine("\n1. TURN ON THE LIGHT");
        Console.WriteLine("2. TURN OFF THE LIGHT");
        Console.WriteLine("3. WHAT IS THE COLOR OF THE LIGHT?");
        Console.WriteLine("4. IS THE LAMP ON?\n");
        Console.Write("PLEASE CHOOSE ONE: ");
        var input = Console.ReadLine();
        var isValid = int.TryParse(input, out var choice);
        if (!isValid) return;

        switch (choice)
        {
            case 1:
                TurnOn();
                break;
            case 2:
                TurnOff();
                break;
            case 3:
                ShowColor();
                break;
            case 4:
                IsOn();
                break;
            default:
                Console.WriteLine("\n>>> INVALID INPUT <<<\n");
                break;
        }
    }
}