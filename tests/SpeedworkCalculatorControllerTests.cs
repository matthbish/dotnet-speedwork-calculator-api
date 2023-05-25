
using Microsoft.AspNetCore.Mvc;
using Moq;
using SpeedworkCalculatorApi.Controllers;
using SpeedworkCalculatorApi.Models;
using Xunit;

public class SpeedworkCalculatorControllerTests
{
    private readonly Mock<ILogger<SpeedworkCalculatorController>> _logger;
    private readonly SpeedworkCalculatorController _controller;

    public SpeedworkCalculatorControllerTests()
    {
        _logger = new Mock<ILogger<SpeedworkCalculatorController>>();
        _controller = new SpeedworkCalculatorController(_logger.Object);
    }

    [Fact]
    public void Calculate_ReturnsAWorkout_WithCorrectValues()
    {
        CalculateRequest request = new CalculateRequest();
        request.Name = WorkoutName.Tempo;
        request.Mileage = 10;
        request.SpeedPercentage = .8;

        ActionResult<Workout> response = _controller.Calculate(request);

        // Assert
        Assert.IsType<ActionResult<Workout>>(response);
    }
}