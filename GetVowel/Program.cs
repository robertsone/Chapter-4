using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type in one letter!");
            while (true)
            {
                string letter =(System.Console.ReadLine()).ToLower();
                if (letter == "a" || letter == "e" || letter == "o" || letter == "u" || letter == "i")
                    System.Console.WriteLine("ok");
                else if (letter == "!")
                    break;
                else
                    System.Console.WriteLine("NO!");

            }
        }
    }
}
