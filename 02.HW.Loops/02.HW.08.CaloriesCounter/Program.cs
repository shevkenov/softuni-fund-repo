using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HW._08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            int caloriesSum = 0;

            for (int i = 1; i <= numberOfIngredients; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient.ToLower() == "cheese")
                {
                    caloriesSum += 500;
                }
                else if(ingredient.ToLower() == "tomato sauce")
                {
                    caloriesSum += 150;
                }
                else if(ingredient.ToLower() == "salami")
                {
                    caloriesSum += 600;
                }
                else if(ingredient.ToLower() == "pepper")
                {
                    caloriesSum += 50;
                }
            }
            Console.WriteLine($"Total calories: {caloriesSum}");
            Console.ReadLine();
        }
    }
}
