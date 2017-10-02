using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HW._05.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            var healthPipes = new String('|', currentHealth);
            var healthDotes = new String('.', maxHealth - currentHealth);
            var energyPipes = new String('|', currentEnergy);
            var energyDotes = new String('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthPipes}{healthDotes}|");
            Console.WriteLine($"Energy: |{energyPipes}{energyDotes}|");
            Console.ReadLine();
        }
    }
}
