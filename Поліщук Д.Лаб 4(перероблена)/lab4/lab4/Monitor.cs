using System;

namespace Lab4
{
    class Monitor : PersonalComputer
    {
        public Monitor(bool needsRebooting, string brand, decimal price, int yearOfRelease, string serialNumber, string country) : base(needsRebooting, brand, price, yearOfRelease, serialNumber, country)
        {
            NeedsRebooting = needsRebooting;
            Price = price;
            YearOfRelease = yearOfRelease;
            SerialNumber = serialNumber;
            Brand = brand;
            Country = country;
        }

    }
}
