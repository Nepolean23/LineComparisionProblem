using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class UC_1
    {
        public static void calculatinglengthofline()
        {
            double x1, y1, x2, y2;
            Console.WriteLine("Enter the value for X1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for X2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for y2");
            y2 = Convert.ToDouble(Console.ReadLine());
             
            double length1=Math.Sqrt(Math.Pow(x2 - x1,2)+Math.Pow(y2 - y1,2));
            Console.WriteLine("The value of length1" + length1);

        }

    }
}
