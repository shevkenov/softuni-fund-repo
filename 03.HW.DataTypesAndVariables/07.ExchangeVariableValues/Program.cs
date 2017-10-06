using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int newSecondNumber = firstNumber;
            int newFirstNumber = secondNumber;
            Console.WriteLine("Before:");
            Console.WriteLine("a = " + firstNumber);
            Console.WriteLine("b = " + secondNumber);
            Console.WriteLine("After:");
            Console.WriteLine("a = " + newFirstNumber);
            Console.WriteLine("b = " + newSecondNumber);
            Console.ReadLine();
        }
    }
}
