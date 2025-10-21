namespace backend.Models;

public class Device(int id, string? name, int signalStrength)
{
    public int Id { get; set; } = id;
    public string? Name { get; set; } = name;
    public string Status => SignalStrength < 20 ? "Offline" : "Online";
    public int SignalStrength { get; set; } = signalStrength;
    public TimeSpan Uptime { get; set; }
}