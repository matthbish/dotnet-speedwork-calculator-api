namespace SpeedworkCalculatorApi.Models;

public class WorkoutType
{
    public WorkoutName Name { get; set; }

    public bool Repeats { get; set; }

    // The distance of a single repeat's run.
    public double? Run { get; set; }

    // The distance of a single repeat's rest.
    public double? Rest { get; set; }

    public WorkoutType(WorkoutName name, bool repeats, double run, double rest)
    {
        Name = name;
        Repeats = repeats;
        Run = run;
        Rest = rest;
    }

    public WorkoutType(WorkoutName name, bool repeats)
    {
        Name = name;
        Repeats = repeats;
    }
}