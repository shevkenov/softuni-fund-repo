using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PracticeCharactersAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string someSentence = Console.ReadLine();
            char someChar1 = char.Parse(Console.ReadLine());
            char someChar2 = char.Parse(Console.ReadLine());
            char someChar3 = char.Parse(Console.ReadLine());
            string someSentence2 = Console.ReadLine();

            Console.WriteLine(someSentence);
            Console.WriteLine(someChar1);
            Console.WriteLine(someChar2);
            Console.WriteLine(someChar3);
            Console.WriteLine(someSentence2);
            Console.ReadLine();
        }
    }
}
