using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float distanceInHours = float.Parse(Console.ReadLine());
            float distanceInMinutes = float.Parse(Console.ReadLine());
            float distanceInSeconds = float.Parse(Console.ReadLine());
            float wholeTimeInSeconds = (distanceInHours * 60 * 60) + (distanceInMinutes * 60) + distanceInSeconds;
            float metresPerSecond = distanceInMeters / wholeTimeInSeconds;
            float timeInhours = wholeTimeInSeconds / 3600;
            float kilometresPerHour = (distanceInMeters / 1000) / (timeInhours);
            float milesPerHour = distanceInMeters / 1609 / timeInhours;

            Console.WriteLine(metresPerSecond);
            Console.WriteLine(kilometresPerHour);
            Console.WriteLine(milesPerHour);
            Console.ReadLine();
        }
    }
}
