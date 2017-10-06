using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string heks = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(heks,16));
            Console.ReadLine();
        }
    }
}
