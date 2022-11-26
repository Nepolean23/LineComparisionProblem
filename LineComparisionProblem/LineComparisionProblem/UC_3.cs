using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class UC_3
    {
        public static void comparemethod()
        {
            double P, Q, R, S;
            double X1, X2, Y1, Y2;
          
            Console.WriteLine("Enter the value for X1");
            X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for X2");
            X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for Y1");
            Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for Y2");
            Y2 = Convert.ToDouble(Console.ReadLine());

            double length1 = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("The value of length1:" + length1);


            Console.WriteLine("\n" + "Enter the value for P");
            P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for Q");
            Q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for R");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for S");
            S = Convert.ToDouble(Console.ReadLine());

            double length2 = Math.Sqrt(Math.Pow(P - Q, 2) + Math.Pow(R - S, 2));
            Console.WriteLine("The value of length2:" + length2);

            //Comparision of length1 and length2
            Console.WriteLine("\n" + "Comparision of length1 and length2");

            if (length1 == length2)
            {
                Console.WriteLine("\n"+"Both lines are in equal length");
            }
            else if (length1 < length2)
            {
                Console.WriteLine("\n"+"length1 is greater than length2");
            }
            else
            {
                Console.WriteLine("\n"+"length2 is greater than length1");
            }

            //Comparing of line using CompareToMethod
            Console.WriteLine("\n" +"Comparing of line using CompareToMethod");
                
            int result=length1.CompareTo(length2);
            Console.WriteLine("\n"+"The value of length is: " + result);
            
            if(result == 0)
            {
                Console.WriteLine("\n"+"Lengths are equal");
            }
            else if(result>0)
            {
                Console.WriteLine("\n" +"line 1 greater than line 2");
            }
           else
            {
                Console.WriteLine("\n"+"line 2 greater than line 1");
            }

         
          


        }
    }
}
