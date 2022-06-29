using System;

namespace Lab4
{
    class Smartphone : Device
    {
        public Smartphone(bool needsReooting, string brand, decimal price, int yearOfRelease, string serialNumber, string country)
        {
            NeedsRebooting = needsReooting;
            Price = price;
            YearOfRelease = yearOfRelease;
            SerialNumber = serialNumber;
            Brand = brand;
            Country = country;
        }
    }
}
