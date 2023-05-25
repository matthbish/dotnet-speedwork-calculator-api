namespace SpeedworkCalculatorApi.Models;

public class Workout // TODO comment these variables
{
    public WorkoutName Name { get; set; }

    public long Repeats { get; set; }

    public double Warmup { get; set; }

    public double Run { get; set; }

    public double? Rest { get; set; }

    public double RepeatsTotal { get; set; }

    public double Cooldown { get; set; }

    public double Total { get; set; }
}