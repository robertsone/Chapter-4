using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect
{class Program{static void Main(string[] args){int Num_counter = 5; int num_sum = 0; while (true){Num_counter += 1; num_sum = 0; int Number_counter_in_number_counter = Num_counter - 1; while (true){Number_counter_in_number_counter -= 1; if (Number_counter_in_number_counter == 0) if (Num_counter == num_sum){System.Console.WriteLine(num_sum);break;}else{break;}if (Num_counter % Number_counter_in_number_counter == 0){num_sum += Number_counter_in_number_counter;}}}}}}