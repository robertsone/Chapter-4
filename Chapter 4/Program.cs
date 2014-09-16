using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter any numbers you want,then type 999 to sum them");
            int sum = 0;
            while (true)
            {
                int num = (Convert.ToInt32(Console.ReadLine()));
                if (num == 999)
                    break;
                else
                    sum += num;

                
            }
            System.Console.WriteLine("Your sum is " + sum);
        }
    }
}
