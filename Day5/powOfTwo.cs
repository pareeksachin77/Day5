using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class powOfTwo { 


       public static void poweroftwocalculate()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num < 0 || num >= 31)
            {
                Console.Write("Please enter a valid number : ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2's Power " + i + "is  :" + Math.Pow(2, i));
            }
        }
    }
}
