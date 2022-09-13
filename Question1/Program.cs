using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            int year = 2022;

            while (count < 80)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0 && year % 400 == 0)
                    {

                    }
                    else if (year % 100 != 0)
                    {

                    }

                    Console.WriteLine(year);

                }
                year++;
                count++;
            }
        }
    }
}
