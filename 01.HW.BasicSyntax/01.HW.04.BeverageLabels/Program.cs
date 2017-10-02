using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HW._04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarContent = double.Parse(Console.ReadLine());
            var energyResult = (volume * energyContent) / 100;
            double sugarResult = (volume * sugarContent) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyResult}kcal, {sugarResult}g sugars");
            Console.ReadLine();
        }
    }
}
