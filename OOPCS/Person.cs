namespace OOPCS;

public class Person: IClickable
{
    private int x, y;

    public Person(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public (int, int) GetPosition()
    {
        return (x, y);
    }

    public void OnClick(Click click)
    {
        Console.WriteLine("I'm clicked at {0}, {1}", click.X, click.Y);
    }
}