using backend.Models;

namespace backend.Services;

public class DeviceService
{
    private static readonly Random Random = new Random();

    private readonly List<Device> _devices =
    [
        new Device(1, "Device Alpha", Random.Next(101)),
        new Device(2, "Device Bravo", Random.Next(101)),
        new Device(3, "Device Charlie", Random.Next(101))
    ];
    
    public IEnumerable<Device> GetAllDevices()
    {
        foreach (var d in _devices)
        {
            d.SignalStrength = Math.Clamp(d.SignalStrength + Random.Next(-5, 6), 0, 100);
            d.Uptime = TimeSpan.FromHours(Random.Next(1, 500));
        }
        return _devices;
    }

    public Device? GetDevice(int id) =>
        _devices.FirstOrDefault(d => d.Id == id);
}