using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HW._12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = 0;
            int turns = 0;

            for (int i = firstNumber; i >= 1; i--)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    turns++;
                    int multiply = (i * j) * 3;
                    result += multiply;
                    if (result >= thirdNumber)
                    {
                        break;
                    }
                }
                if (result >= thirdNumber)
                {
                    break;
                }
            }
            if (result >= thirdNumber)
            {
                Console.WriteLine($"{turns} combinations");
                Console.WriteLine($"Sum: {result} >= {thirdNumber}");
            }
            else
            {
                Console.WriteLine($"{turns} combinations");
                Console.WriteLine($"Sum: {result}");
            }
            Console.ReadLine();
        }
    }
}
