public class Date
{
    public int day;
    public int month;
    public int year;
    public int Day;
    public int Month;
    public int Year;


    public Date(){}
    public Date(int day)
    {
        Day = day;
    }

    public Date(int day, int month)
    {
        Day = day;
        Month = month;
    }

    public Date(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public void SetDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public int GetDay()
    {
        return Day;
    }
    public int GetMonth()
    {
        return Month;
    }
    public int GetYear()
    {
        return Year;
    }
    public override string ToString()
{
    return $"{Day:D2}/{Month:D2}/{Year:D4}";
}
}