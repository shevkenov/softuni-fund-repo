using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PracticeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyteNumber = sbyte.Parse(Console.ReadLine());
            byte byteNumber = byte.Parse(Console.ReadLine());
            short shortNumber = short.Parse(Console.ReadLine());
            ushort ushortNumber = ushort.Parse(Console.ReadLine());
            uint uintNumber = uint.Parse(Console.ReadLine());
            int intNumber = int.Parse(Console.ReadLine());
            long longNumber = long.Parse(Console.ReadLine());

            Console.WriteLine(sbyteNumber);
            Console.WriteLine(byteNumber);
            Console.WriteLine(shortNumber);
            Console.WriteLine(ushortNumber);
            Console.WriteLine(uintNumber);
            Console.WriteLine(intNumber);
            Console.WriteLine(longNumber);
            Console.ReadLine();
        }
    }
}
