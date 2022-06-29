using System;

namespace Lab4
{
    internal class ShopOfDevices
    {
        string name;
        public string Name { get { return name; } }
        public Device[] devices;
        public int AmountOfGoods;
        public ShopOfDevices(string name, params Device[] devices)
        {
            this.name = name;   
            this.devices = devices;
            AmountOfGoods = devices.Length;
        }
        public void ShowInfo()
        {
            for (int i = 0; i < devices.Length; i++)
            {
                if (devices[i] is Monitor)
                    Console.Write("Model of monitor:\t");
                else if (devices[i] is PersonalComputer)
                    Console.Write("Model of personal computer:\t");
                else if (devices[i] is Smartphone)
                    Console.Write("Model of smartphone:\t");
                else if (devices[i] is SystemUnit)
                    Console.Write("Model of system unit:\t");
                devices[i].ShowInfo();
            }
        }
        public void FindBrand()
        {
            Console.Write("\nEnter the name of the brand:\t");
            string inputedBrand = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < devices.Length; i++)
            {
                if (devices[i].Brand == inputedBrand)
                {
                    if (devices[i] is Monitor)
                        Console.Write("Model of monitor:\t");
                    else if (devices[i] is PersonalComputer)
                        Console.Write("Model of personal computer:\t");
                    else if (devices[i] is Smartphone)
                        Console.Write("Model of smartphone:\t");
                    else if (devices[i] is SystemUnit)
                        Console.Write("Model of system unit:\t");
                    devices[i].ShowInfo();
                    counter++;
                }
            }
            if (counter == 0)
                Console.WriteLine("\nNothing is found!");
        }
        public void FindByCategory()
        {
            Console.Write("\nEnter the necessary category:\t");
            string inputedCategory = Console.ReadLine();
            if (inputedCategory == "monitor")
            {
                for (int i = 0; i < devices.Length; i++)
                    if (devices[i] is Monitor)
                        devices[i].ShowInfo();
            }
            else if (inputedCategory == "personal computer")
            {
                for (int i = 0; i < devices.Length; i++)
                    if (devices[i] is PersonalComputer)
                        devices[i].ShowInfo();
            }
            else if (inputedCategory == "smartphone")
            {
                for (int i = 0; i < devices.Length; i++)
                    if (devices[i] is Smartphone)
                        devices[i].ShowInfo();
            }
            else if (inputedCategory == "system unit")
            {
                for (int i = 0; i < devices.Length; i++)
                    if (devices[i] is SystemUnit)
                        devices[i].ShowInfo();
            }
            else
                Console.WriteLine("Nothing is found!");
        }
        public void CountFullPrice()
        {
            decimal sum = 0;
            for (int i = 0; i < devices.Length; i++)
                sum += devices[i].Price;
            Console.WriteLine("\nThe price of all devices is equal to {0}", sum);
        }
        public void AddNewDevice()
        {
            Console.Write("Enter the category of device:\t");
            string inputedCategory = Console.ReadLine();
            Console.Write("Enter the brand:\t");
            string inputedBrand = Console.ReadLine();
            Console.Write("Enter the price:\t");
            decimal inputedPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the year of release:\t");
            int inputedYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the serial number:\t");
            string inputedSerialNumber = Console.ReadLine();
            Console.Write("Enter the contry:\t");
            string inputedCountry = Console.ReadLine();
            Device newDevice = null;
            if (inputedCategory == "monitor")
                newDevice = new Monitor(false, inputedBrand, inputedPrice, inputedYear, inputedSerialNumber, inputedCountry);
            else if (inputedCategory == "personal computer")
                newDevice = new PersonalComputer(false, inputedBrand, inputedPrice, inputedYear, inputedSerialNumber, inputedCountry);
            else if (inputedCategory == "smartphone")
                newDevice = new Smartphone(false, inputedBrand, inputedPrice, inputedYear, inputedSerialNumber, inputedCountry);
            else if (inputedCategory == "system unit")
                newDevice = new SystemUnit(false, inputedBrand, inputedPrice, inputedYear, inputedSerialNumber, inputedCountry);
            else
                Console.WriteLine("\nSomething is wrong!");
            Array.Resize(ref devices, devices.Length + 1);
            devices[devices.Length - 1] = newDevice;
        }
    }
}

