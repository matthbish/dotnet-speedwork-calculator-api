using System.Text.Json.Serialization;

namespace SpeedworkCalculatorApi.Models;

public class CalculateRequest
{
    public double Mileage { get; set; }

    public double SpeedPercentage { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WorkoutName Name { get; set; }
}