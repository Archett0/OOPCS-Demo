namespace OOPCS;

public class TestPerson
{
    static void Main(string[] args)
    {
        (int, int) pos;

        Person person = new Person(12, 12);
        Click click = new Click(15, 15);

        pos = person.GetPosition();
        if ((click.X >= pos.Item1 && click.X <= pos.Item1 + 100) &
            (click.Y >= pos.Item2 && click.Y <= pos.Item2 + 100))
        {
            person.OnClick(click);
        }
    }
}