using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HW._13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNo = int.Parse(Console.ReadLine());
            int secondNo = int.Parse(Console.ReadLine());
            int magicNo = int.Parse(Console.ReadLine());
            string result = "";
            int turns = 0;

            for (int i = firstNo; i <= secondNo; i++)
            {
                for (int j = firstNo; j <= secondNo; j++)
                {
                    turns++;
                    if (j + i == magicNo)
                    {
                        result = $"{i} + {j} = {magicNo}";
                    }
                }
            }
            if (result != "")
            {
                Console.WriteLine("Number found! " + result);
            }
            else
            {
                Console.WriteLine($"{turns} combinations - neither equals {magicNo}");
            }
            Console.ReadLine();
        }
    }
}
