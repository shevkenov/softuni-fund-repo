using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HW._05.WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);
                noun += "ies";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("x") || noun.EndsWith("z") || noun.EndsWith("ch") || noun.EndsWith("sh") || noun.EndsWith("sh"))
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }
            Console.WriteLine(noun);
            Console.ReadLine();

        }
    }
}
