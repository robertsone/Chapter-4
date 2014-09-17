using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num < 21; num += 1)
            {
                System.Console.WriteLine(num+"\t"+num*num);
            }
        }
    }
}
