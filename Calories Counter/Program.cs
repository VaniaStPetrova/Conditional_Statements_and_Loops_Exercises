using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ingredient = string.Empty;
            int calories = 0;

            for (int i = 0; i < n; i++)
            {
                ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories = calories + 500;
                        break;
                    case "tomato sauce":
                        calories = calories + 150;
                        break;
                    case "salami":
                        calories = calories + 600;
                        break;
                    case "pepper":
                        calories = calories + 50;
                        break;
                }
            }
            Console.WriteLine("Total calories: {0}", calories);
        }
    }
}
