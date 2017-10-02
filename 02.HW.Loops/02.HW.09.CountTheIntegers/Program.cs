using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HW._09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCounter = 0;

            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    numberCounter++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(numberCounter);
            Console.ReadLine();
        }
    }
}
