public class EternalGoals : Goal
{

    public EternalGoals(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

}