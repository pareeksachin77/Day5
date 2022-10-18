using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class HarmonicNumber
    {
        public static void harmonic()
        {
            double harmonicSum = 0;
            Console.Write("Enter the number to find Harmonic number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (double i = 1; i <= num; i++)
            {
                Console.Write("1/{0} ", i);
                harmonicSum += (1 / i);
            }
            Console.WriteLine("\n The Sum of harmonic number is:" + harmonicSum);
        }
    }
}
