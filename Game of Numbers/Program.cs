using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int lastFoundFirstMember = 0;
            int lastFoundSecondMember = 0;
            bool found = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;

                    if (i + j == magicNumber)
                    {
                        lastFoundFirstMember = i;
                        lastFoundSecondMember = j;
                        found = true;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", lastFoundFirstMember, lastFoundSecondMember, magicNumber);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
            }
        }
    }
}
