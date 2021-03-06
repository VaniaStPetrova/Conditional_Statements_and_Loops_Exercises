﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int combinations = 0;
            int sum = 0;
            for (int i = number1; i >= 1; i--)
            {
                for (int j = 1; j <= number2; j++)
                {
                    sum += 3 * i * j;
                    combinations++;
                    if (sum >= boundary)
                    {
                        Console.WriteLine("{0} combinations", combinations);
                        Console.WriteLine("Sum: {0} >= {1}", sum, boundary);
                        return;
                    }
                }
            }

            Console.WriteLine("{0} combinations", combinations);
            Console.WriteLine("Sum: {0}", sum);

        }
    }
}
