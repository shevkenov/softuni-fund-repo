using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HW._03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double discount = 0;
            double price = 0;
            string hall = "";
            double total = 0;
            double pricePerPersone = 0;

            switch (package)
            {
                case "Normal":
                    discount = 0.05;
                    price = 500;
                    break;
                case "Gold":
                    discount = 0.10;
                    price = 750;
                    break;
                case "Platinum":
                    discount = 0.15;
                    price = 1000;
                    break;
            }
            if (groupSize > 0 && groupSize <= 50)
            {
                total = 2500 + price;
                total = total - (total * discount);
                pricePerPersone = total / groupSize;
                hall = "Small Hall";
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPersone:F2}$");
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                total = 5000 + price;
                total = total - (total * discount);
                pricePerPersone = total / groupSize;
                hall = "Terrace";
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPersone:F2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                total = 7500 + price;
                total = total - (total * discount);
                pricePerPersone = total / groupSize;
                hall = "Great Hall";
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPersone:F2}$");
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            Console.ReadLine();
        }
    }
}
