using backend.Models;

namespace backend.Services;

public class DeviceService
{
    private static readonly Random Random = new Random();

    // Hardcoded list of devices for testing/experimenting
    private readonly List<Device> _devices =
    [
        new Device(1, "Device Alpha", Random.Next(101)),
        new Device(2, "Device Bravo", Random.Next(101)),
        new Device(3, "Device Charlie", Random.Next(101))
    ];
    
    // Function to get all devices from the hardcoded list
    // Also randomly adjusts signal strength as basic device simulation
    public IEnumerable<Device> GetAllDevices()
    {
        foreach (var d in _devices)
        {
            d.SignalStrength = Math.Clamp(d.SignalStrength + Random.Next(-5, 6), 0, 100);
        }
        return _devices;
    }

    // Function to get single device from an id
    public Device? GetDevice(int id) =>
        _devices.FirstOrDefault(d => d.Id == id);
}