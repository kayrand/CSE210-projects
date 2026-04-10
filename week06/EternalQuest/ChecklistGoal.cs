public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted)
        : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            if (_amountCompleted == _target)
            {
                return GetPoints() + _bonus;
            }

            return GetPoints();
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string box = "[ ]";

        if (IsComplete())
        {
            box = "[X]";
        }

        return box + " " + GetShortName() + " (" + GetDescription() + ") -- Currently completed: " + _amountCompleted + "/" + _target;
    }

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal:" + GetShortName() + "," + GetDescription() + "," + GetPoints() + "," + _bonus + "," + _target + "," + _amountCompleted;
    }
}