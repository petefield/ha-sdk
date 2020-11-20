using System.Collections.Generic;

namespace ha.sdk
{
    public interface IDevice
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string DeviceType { get; set; }
        IDictionary<string, string> Config { get; set; }
    }
}
