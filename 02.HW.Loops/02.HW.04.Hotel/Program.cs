using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HW._04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double priceForStudio = 0;
            double priceForDouble = 0;
            double priceForSuite = 0;


            switch (mounth)
            {
                case "May":
                case "October":
                    priceForStudio = 50;
                    priceForDouble = 65;
                    priceForSuite = 75;
                    if (nightsCount > 7)
                    {
                        priceForStudio = priceForStudio - (priceForStudio * 0.05);
                    }
                    break;
                case "June":
                case "September":
                    priceForStudio = 60;
                    priceForDouble = 72;
                    priceForSuite = 82;
                    if (nightsCount > 14)
                    {
                        priceForDouble = priceForDouble - (priceForDouble * 0.10);
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    priceForStudio = 68;
                    priceForDouble = 77;
                    priceForSuite = 89;
                    if (nightsCount > 14)
                    {
                        priceForSuite = priceForSuite - (priceForSuite * 0.15);
                    }
                    break;
            }

            if (mounth == "September" && nightsCount > 7 || mounth == "October" && nightsCount > 7)
            {
                Console.WriteLine($"Studio: {priceForStudio * (nightsCount-1):F2} lv.");
            }
            else
            {
                Console.WriteLine($"Studio: {priceForStudio * nightsCount:F2} lv.");
            }
            Console.WriteLine($"Double: {priceForDouble * nightsCount:F2} lv.");
            Console.WriteLine($"Suite: {priceForSuite * nightsCount:F2} lv.");
            Console.ReadLine();
        }
    }
}
