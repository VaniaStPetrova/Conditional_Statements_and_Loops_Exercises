using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantities = int.Parse(Console.ReadLine());
            double Price = 0.0;
            if (profession == "Athlete")
            {
                Price = quantities * 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Price = quantities * 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                Price = quantities * 1.70;
            }
            else
            {
                Price = quantities * 1.20;
            }
            Console.WriteLine("The {0} has to pay {1:F2}.", profession, Price);
        }
    }
}
