using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUpskilling
{
    public class Calculation : Test
    {
        public void Addition(params double[] numbers)
        {
            double total = 0;
            foreach (var number in numbers)
            {
                total += number;
            }
            Console.WriteLine("Addition of numbers = " + total);
        }
    }
}
