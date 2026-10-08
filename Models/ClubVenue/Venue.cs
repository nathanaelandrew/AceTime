namespace BlazorApp1.Models;

public class Venue
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Coordinates { get; set; } = string.Empty;
    
    public List<Court> Courts { get; set; } = new();
}

public class Court
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid VenueId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string SurfaceType { get; set; } = string.Empty;
    public bool HasLights { get; set; }
}