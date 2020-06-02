using Composite.Computer.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Computer
{
    public interface IDeviceComponent
    {
        DeviceType GetDeviceType();
        int GetPrice();
    }
}
