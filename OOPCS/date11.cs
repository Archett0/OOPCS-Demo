namespace OOPCS;

public class date11
{
    private int _day;
    private int _month;
    private int _year;

    public date11(int day, int month, int year)
    {
        _day = day;
        _month = month;
        _year = year;
    }

    public date11(date11 newDate11)
    {
        _day = newDate11._day;
        _month = newDate11._month;
        _year = newDate11._year;
    }

    public int Day
    {
        get => _day;
        set => _day = value;
    }

    public int Month
    {
        get => _month;
        set => _month = value;
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public void PrintDateDetails()
    {
        Console.WriteLine("Date: {0}/{1}/{2}", Day, Month, Year);
    }
}