using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiplicationtable
{
    class Program
    {
        static void Main(string[] args)
        {   int table_x=-1;
            int table_y = -1;
            string temp = " ";

            while (true)
            {
                table_y += 1;
                temp = temp + "    " + table_y;
                if (table_y > 9)
                    break;
            }
            System.Console.WriteLine(temp);
            table_y = 0;
            while (true)
            {

                table_x += 1;

                string row = ""+table_x;
                while (true)
                {
                    string space = "";
                    int conversion = (table_y * table_x);
                    int spaces = 5-(Convert.ToString(conversion).Length);
                    while (spaces>0)
                    {
                        spaces -= 1;
                        space = space + " ";
                    }

                    row = row + space + table_y * table_x;
                    table_y += 1;
                    if (table_y>10)
                        break;

                }
                System.Console.WriteLine (row);
                table_y = 0;
                if (table_x > 9)
                    break;

            }
        }
    }
}
