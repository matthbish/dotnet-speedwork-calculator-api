namespace SpeedworkCalculatorApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using SpeedworkCalculatorApi.Models;
using SpeedworkCalculatorApi.Constants;

[ApiController]
[Route("[controller]")]
public class SpeedworkCalculatorController : ControllerBase
{

    private readonly ILogger<SpeedworkCalculatorController> _logger;

    public SpeedworkCalculatorController(ILogger<SpeedworkCalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "Calculate")]
    public ActionResult<Workout> Calculate(CalculateRequest request)
    {
        WorkoutType workoutType = WorkoutConstants.getWorkoutType(request.Name);
        Workout workout = new Workout();
        workout.Name = workoutType.Name;
        double run = workoutType.Run.HasValue ? workoutType.Run.Value : (request.Mileage * request.SpeedPercentage);
        double rest = workoutType.Rest.HasValue ? workoutType.Rest.Value : 0;
        workout.Repeats = run + rest > 0
        ? Convert.ToInt64(Math.Round(request.Mileage * request.SpeedPercentage) / (run + rest))
        : 0;
        workout.Rest = workoutType.Rest;
        workout.Run = run;
        workout.RepeatsTotal = workout.Repeats * (rest + run);
        workout.Warmup = 1; // TODO implement an API option to override default warmup distance
        workout.Cooldown = request.Mileage - (workout.Warmup + workout.RepeatsTotal);

        Response.StatusCode = StatusCodes.Status200OK;
        return new Workout();
    }
}
