namespace Exercise;

public class DateType
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public DateType(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public DateType()
    {
        Day = 1;
        Month = 1;
        Year = 1900;
    }

    public override string ToString()
    {
        var res = Day + "/" + Month + "/" + Year;
        return res;
    }
}