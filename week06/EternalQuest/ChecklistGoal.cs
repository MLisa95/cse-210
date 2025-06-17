public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;

            if (_currentCount == _targetCount)
            {
                return GetPoints() + _bonusPoints; // goal complete: points + bonus
            }

            else
            {
                return GetPoints(); // progress made, not complete
            }
        }
        else
        {
            return 0; // already completed so no points
        }
    }

    public string GetStatus()
    {
        string checkbox = (_currentCount >= _targetCount) ? "[X]" : "[ ]";
        return $"{checkbox} {GetName()} [{GetDescription}] -- Completed {_currentCount}/{_targetCount} times";
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
}