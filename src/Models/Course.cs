namespace RazorFreight.Models;

public class Course
{
    public Guid Id { get; set; }
    public string Origin { get; set; } = string.Empty;
    public string Destination { get; set; } = string.Empty;
    public decimal DistanceInKm { get; set; }
}
