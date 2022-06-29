using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Business
    {
        ShopOfDevices[] listOfShops;
        public Business(params ShopOfDevices[] listOfShops)
        {
            this.listOfShops = listOfShops;
        }
        public void ShowInfo()
        {
            int amUSA = 0, amVietnam = 0, amChina = 0, amJapan = 0;
            int counter;
            for (int i = 0; i < listOfShops.Length; i++)
            {
                Console.WriteLine($"\nShop \"{listOfShops[i].Name}\":");
                Console.WriteLine($"\nAmount of goods: \"{listOfShops[i].AmountOfGoods}\":");
                listOfShops[i].ShowInfo();
                counter = 0;  amUSA = 0; amVietnam = 0; amChina = 0; amJapan = 0;
                for (int j = 0; j < listOfShops[i].devices.Length; j++)
                {
                    if (listOfShops[i].devices[j].NeedsRebooting)
                        counter++;
                    if (listOfShops[i].devices[j].Country == "USA")
                        amUSA++;
                    else if (listOfShops[i].devices[j].Country == "Japan")
                        amJapan++;
                    else if (listOfShops[i].devices[j].Country == "China")
                        amChina++;
                    else if (listOfShops[i].devices[j].Country == "Vietnam")
                        amVietnam++;
                }
                Console.WriteLine($"_________________________\n{counter} devices need rebooting");
                Console.WriteLine($"Amount of goods in USA: {amUSA}; China: {amChina}; Japan: {amJapan}; Vietnam: {amVietnam}");
            }
        }
        public void AddNewShop()
        {
            Console.Write("Enter the name of the shop:\t");
            string inputedName = Console.ReadLine();
            Console.Write("Enter the amount of goods int the shop:\t");
            int inputedAmount = Convert.ToInt32(Console.ReadLine());
            Device[] list = new Device[inputedAmount];
            ShopOfDevices newShop = new ShopOfDevices(inputedName, list);
            for(int i = 0; i < list.Length; i++)
            {
                Console.Write("\nEnter the category of device:\t");
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
                list[i] = newDevice;
            }
            Array.Resize(ref listOfShops, listOfShops.Length + 1);
            listOfShops[listOfShops.Length - 1] = newShop;
        }
    }
}
