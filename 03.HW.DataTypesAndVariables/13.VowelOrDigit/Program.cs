using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            if ((int)symbol >= 48 && (int)symbol <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                if ((int)symbol == 97 || (int)symbol == 101 || (int)symbol == 105 || (int)symbol == 111 || (int)symbol == 117 || (int)symbol == 121)
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }

            }
            Console.ReadLine();
        }
    }
}
