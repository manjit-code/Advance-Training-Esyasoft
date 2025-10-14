using System;
using System.Collections.Generic;

namespace BasicsInterface
{

    // Question 1: Smart Home Device System
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan myFan = new Fan("Havel Fan", false, 60);
            Light myLight = new Light("Suriya Lights", false, 85);
            Thermostat myThermo = new Thermostat("medic thermo", false, 97.50);
            List<ISmartDevice> devices = new List<ISmartDevice>();
            devices.Add(myFan);
            devices.Add(myLight);
            devices.Add(myThermo);

            foreach (ISmartDevice device in devices)
            {
                device.TurnOn();
                device.ConnectToWiFi();
                device.ShowStatus();
            }
        }
    }

    interface IDevice
    {
        string DeviceName { get; set; }
        bool isOn { get; set; }
        void TurnOn();
        void TurnOff();
    }

    interface ISmartDevice : IDevice
    {
        void ConnectToWiFi();
        void ShowStatus();
    }

    class Light : ISmartDevice
    {
        public int Brightness;
        public string DeviceName { get; set; }
        public bool isOn { get; set; }

        public Light(string DeviceName, bool isOn, int Brightness)
        {
            this.DeviceName = DeviceName;
            this.isOn = isOn;
            this.Brightness = Brightness;
        }

        public void TurnOn()
        {
            this.isOn = true;
            Console.WriteLine($"{DeviceName} is now on.");
        }

        public void TurnOff()
        {
            this.isOn = false;
            Console.WriteLine($"{DeviceName} is now off.");
        }

        public void ConnectToWiFi()
        {
            Console.WriteLine($"{DeviceName} is connecting to Wi-Fi...");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Light Status: {DeviceName}, Is On: {isOn}, Brightness: {Brightness}");
        }
    }

    class Fan : ISmartDevice
    {
        public double Speed;
        public string DeviceName { get; set; }
        public bool isOn { get; set; }

        public Fan(string DeviceName, bool isOn, double speed)
        {
            this.DeviceName = DeviceName;
            this.isOn = isOn;
            this.Speed = speed;
        }

        public void TurnOn()
        {
            this.isOn = true;
            Console.WriteLine($"{DeviceName} is now on.");
        }

        public void TurnOff()
        {
            this.isOn = false;
            Console.WriteLine($"{DeviceName} is now off.");
        }

        public void ConnectToWiFi()
        {
            Console.WriteLine($"{DeviceName} is connecting to Wi-Fi...");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Fan Status: {DeviceName}, Is On: {isOn}, Speed: {Speed}");
        }

        public override string ToString()
        {
            return $"Fan Status: {DeviceName}, Is On: {isOn}, Speed: {Speed}";
        }
    }

    class Thermostat : ISmartDevice
    {
        public double Temperature;
        public string DeviceName { get; set; }
        public bool isOn { get; set; }

        public Thermostat(string DeviceName, bool isOn, double Temperature)
        {
            this.DeviceName = DeviceName;
            this.isOn = isOn;
            this.Temperature = Temperature;
        }

        public void TurnOn()
        {
            this.isOn = true;
            Console.WriteLine($"{DeviceName} is now on.");
        }

        public void TurnOff()
        {
            this.isOn = false;
            Console.WriteLine($"{DeviceName} is now off.");
        }

        public void ConnectToWiFi()
        {
            Console.WriteLine($"{DeviceName} is connecting to Wi-Fi...");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Thermostat Status: {DeviceName}, Is On: {isOn}, Temperature: {Temperature}");
        }
    }
}
