using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class FlipCoin
    {
        public static void uc1()
        {
            Console.WriteLine("Enter How Many The number of times to Flip Coin.");
            double n = Convert.ToDouble(Console.ReadLine());
            int head = 0;
            int tail = 0;
            int i = 0;
            Random random = new Random();
            for (i = 0; i <= n; i++)
            {
                double check = random.NextDouble();
                if(check< 0.5)
                {
                    Console.WriteLine("Tails");
                    tail++;
                }
                else
                {
                    Console.WriteLine("Head");
                    head++;
                }
                Console.WriteLine("number of heads= "+ head);
                Console.WriteLine("number of tails= "+ tail);
                double headpercentage = (head * 100) / n;
                double tailpercentage = (tail * 100) / n;
                Console.WriteLine(" Percentage of head is : " + headpercentage);
                Console.WriteLine("Percentage of tails is : " + tailpercentage);


            }

        }
    }
}
