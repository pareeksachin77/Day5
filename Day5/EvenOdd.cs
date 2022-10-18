using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class EvenOdd
    {
        public static void evenoddNumber()
        {
            Console.WriteLine("Enter Any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("{0} is even number", num);
            else
                Console.WriteLine("{0} is odd number", num);
        }
    }
}
