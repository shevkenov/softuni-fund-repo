using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centery = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centery * 100);
            uint days = (uint)(years * 365.2422);
            ulong hours = (days * 24);
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centery} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            Console.ReadLine();
        }
    }
}
