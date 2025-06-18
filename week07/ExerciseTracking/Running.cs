public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()}\nRunning ({GetMinutes()} min) - Distance: {GetDistance():0.0} kms\nSpeed: {GetSpeed()} m/km\nPace: {GetPace():0.0} min/km";
    }
}