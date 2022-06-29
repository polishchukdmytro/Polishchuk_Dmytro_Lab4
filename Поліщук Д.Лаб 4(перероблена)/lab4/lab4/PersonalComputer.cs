using System;

namespace Lab4
{
    class PersonalComputer : Device
    {
        public PersonalComputer(bool needsRebootnig, string brand, decimal price, int yearOfRelease, string serialNumber, string country)
        {
            NeedsRebooting = needsRebootnig;
            Price = price;
            YearOfRelease = yearOfRelease;
            SerialNumber = serialNumber;
            Brand = brand;
            Country = country;
        }
        public void ConnectMonitor(bool needsRebooting, string brand, decimal price, int yearOfRelease, string serialNumber, string country)
        {
            Device monitor = new Monitor(needsRebooting, brand, price, yearOfRelease, serialNumber, country);
            Console.WriteLine("Connecting new monitor...\n");
            monitor.TurnOn();
            monitor.ShowInfo();
        }
        public void ConnectSystemUnit(bool needsRebooting, string brand, decimal price, int yearOfRelease, string serialNumber, string country)
        {
            Device systemUnit = new SystemUnit(needsRebooting, brand, price, yearOfRelease, serialNumber, country);
            Console.WriteLine("Connecting new system unit...\n");
            systemUnit.TurnOn();
            systemUnit.ShowInfo();
        }
        public void DisconnectMonitor(bool needsRebooting, string brand, decimal price, int yearOfRelease, string serialNumber, string country)
        {
            Device monitor = new Monitor(needsRebooting, brand, price, yearOfRelease, serialNumber, country);
            Console.WriteLine("Disconnecting monitor...\n");
            monitor.TurnOff();
        }
        public void DisconnectSystemUnit(bool needsRebooting, string brand, decimal price, int yearOfRelease, string serialNumber, string country)
        {
            Device systemUnit = new SystemUnit(needsRebooting, brand, price, yearOfRelease, serialNumber, country);
            Console.WriteLine("Disconnecting system unit...\n");
            systemUnit.TurnOff();
        }
    }
}

