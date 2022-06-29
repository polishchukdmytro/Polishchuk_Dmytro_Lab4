using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        static void Main() 
        {
            Device smartphone1 = new Smartphone(true, "samsung", 800, 2022, "GM2929", "Vietnam");
            Device smartphone2 = new Smartphone(false, "apple", 1200, 2020, "QP2290", "USA");
            Device smartphone3 = new Smartphone(true, "samsung", 900, 2021, "GM34234", "Vietnam");
            Device smartphone4 = new Smartphone(false, "xiaomi", 800, 2018, "JK45429", "Japan");
            Device smartphone5 = new Smartphone(false, "POCO", 1000, 2021, "KS35429", "China");
            Device personalComputer1 = new PersonalComputer(false, "lenovo", 1800, 2021, "UL320", "Japan");
            Device personalComputer2 = new PersonalComputer(false, "apple", 2900, 2021, "IO320", "USA");
            Device systemUnit1 = new SystemUnit(false, "acer", 400, 2020, "QT23214", "China");
            Device systemUnit2 = new SystemUnit(true, "oppo", 300, 2019, "JK23454", "China");
            Device monitor1 = new Monitor(false,"lg", 250, 2021, "MK39238", "Vietnam");
            Device monitor2 = new Monitor(true, "samsung", 300, 2019, "DR2899", "USA");
            Device monitor3 = new Monitor(false, "sony", 500, 2022, "DR0000", "Japan");

            List<Device> listOfAllDevices = new List<Device>() { smartphone1, smartphone2, smartphone3, smartphone4, smartphone5, monitor1, monitor2, monitor3, systemUnit1, systemUnit2, personalComputer1, personalComputer2}; 

            ShopOfDevices shop1 = new ShopOfDevices("MegaShop", smartphone1, smartphone2, smartphone3, systemUnit1, monitor1, monitor2, personalComputer1);
            ShopOfDevices shop2 = new ShopOfDevices("ParadizeOfDevices", smartphone1, smartphone2, smartphone3, smartphone4, smartphone5, systemUnit1,systemUnit2, monitor1, monitor2, personalComputer1);
            ShopOfDevices shop3 = new ShopOfDevices("Allo", smartphone1, smartphone4, smartphone3, systemUnit2, systemUnit2, monitor1, monitor3, personalComputer2);

            Business business = new Business(shop1, shop2, shop3);
            business.ShowInfo();

            Console.WriteLine("\nWould you like to add new shop?(yes|no)");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "yes")
            {
                business.AddNewShop();
                business.ShowInfo();
            }

            Console.ReadKey();
        }
    }
}
