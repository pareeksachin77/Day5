﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class LeapYear
    {
        public static void CheckLaeap()
        {
            Console.WriteLine("Enter Any Year");
            int Year = Convert.ToInt32(Console.ReadLine());
            if(Year%4==0 && Year%100!=0 || Year % 400 == 0)
            {
                Console.WriteLine("{0} is a leap Year" + Year);

            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year",Year);
            }

        }

    }
}
