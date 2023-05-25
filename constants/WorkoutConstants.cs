namespace SpeedworkCalculatorApi.Constants;

using SpeedworkCalculatorApi.Models;

public static class WorkoutConstants
{
    public static WorkoutType Tempo = new WorkoutType(WorkoutName.Tempo, false);
    public static WorkoutType Quarters = new WorkoutType(WorkoutName.Quarters, true, .25, .25);
    public static WorkoutType Halves = new WorkoutType(WorkoutName.Halves, true, .5, .5);

    public static WorkoutType getWorkoutType(WorkoutName name) {
        switch(name) {
            case WorkoutName.Tempo:
                return Tempo;
            case WorkoutName.Quarters:
                return Quarters;
            case WorkoutName.Halves:
                return Halves;
            default:
            return null;
        }
    }
}