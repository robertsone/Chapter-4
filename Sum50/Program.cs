using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int num = 1; num < 51; num += 1)
            {
                sum += num;
                
            }
            System.Console.WriteLine(sum);
        }
    }
}
