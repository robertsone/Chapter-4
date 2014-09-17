using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int Perfect = 0;
            int count = 1;

            while (true)
            {
                count += 1;
                int count_count = count-1;
                int count_sum = 0;
                while (true)
                {
                    if (count % count_count == 0)
                        count_sum += count_count;
                    count_count -= 1;
                    if (count_count == 0)
                        break;
                }
                if (count_sum == count)
                    System.Console.WriteLine(Perfect);
            }
        }
    }
}
