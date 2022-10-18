using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class LargestNumber
    {
        public static void LargestNumbers()
        {
            Console.Write("Enter the First number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("Largest number is : " + firstNumber);

            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("Largest number is : " + secondNumber);
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine("Largest number is : " + thirdNumber);
            }
            else
            {
                Console.WriteLine("All Three numbers are equal");
            }

        }
    }
}

