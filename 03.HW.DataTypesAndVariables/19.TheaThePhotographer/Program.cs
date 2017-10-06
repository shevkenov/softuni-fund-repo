using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictureCount = long.Parse(Console.ReadLine());
            long amountOfTimeInSeconds = long.Parse(Console.ReadLine());
            long percentageOfGoodPicters = long.Parse(Console.ReadLine());
            long amountOfTimeUploadPicture = long.Parse(Console.ReadLine());
      
            long wholeTimeToFilterPicters = pictureCount * amountOfTimeInSeconds;
            double pictureInGoodQuality = Math.Ceiling((pictureCount * percentageOfGoodPicters) / 100.0);
            double wholeTimeToUploadPictures = pictureInGoodQuality * amountOfTimeUploadPicture;
            long wholeTime = (long)(wholeTimeToFilterPicters + wholeTimeToUploadPictures);
            long days = wholeTime / (60 * 60 * 24);
            long hours = (wholeTime / (3600)) % 24;
            long minutes = (wholeTime / 60) % 60;
            long second = wholeTime % 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{second:D2}");
            Console.ReadLine();
        }
    }
}
