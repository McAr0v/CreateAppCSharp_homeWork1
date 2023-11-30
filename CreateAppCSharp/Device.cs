using CreateAppSCharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAppCSharp
{
    public class Device : IControllable
    {
        public bool IsOn { get; private set; } = false;

        public void Off()
        {
            IsOn = false;
            Console.WriteLine("Device is off");
        }

        public void On()
        {
            IsOn = true;
            Console.WriteLine("Device is on");
        }
    }

    public interface IControllable
    {
        bool IsOn { get; }

        void On();
        void Off();
    }

    public class Devices
    {
        public List<IControllable> DevicesList { get; init; }
        public Devices()
        {
            DevicesList = new List<IControllable>
            {

                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device()

            };
                
                
        }

        public void TurnOnOff(Bits bits)
        {
            for (byte i = 0; i < 8; i++)
            {
                if (DevicesList[i].IsOn && !bits[i])
                {
                    DevicesList[i].Off();
                }
                else if (!DevicesList[i].IsOn && bits[i])
                {
                    DevicesList[i].On();
                }

            }
        }

        public override string ToString()
        {
            return string.Join("", DevicesList.Select(s=>s.IsOn?"1":"0"));
        }

    }

}
