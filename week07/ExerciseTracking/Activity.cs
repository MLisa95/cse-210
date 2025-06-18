public class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = DateTime.Now.ToString("dd MMM yyyy");
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    // virtual classes allowing to be overridden in respective classes
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_minutes} min)";
    }

}