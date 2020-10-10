using System;

namespace ha.sdk
{ 
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class DeviceTypeAttribute : Attribute
    {
        public DeviceTypeAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
