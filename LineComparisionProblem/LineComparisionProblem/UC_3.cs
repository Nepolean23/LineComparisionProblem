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

            if (length1 == length2)
            {
                Console.WriteLine("Both lines are in equal length");
            }
            else if (length1 < length2)
            {
                Console.WriteLine("length1 is greater than length2");
            }
            else
            {
                Console.WriteLine("length2 is greater than length1");
            }

            int x = X1.CompareTo(X2);
            int y = Y1.CompareTo(Y2);
            int p = P.CompareTo(Q);
            int q = Q.CompareTo(R);

            if(x==y || p==q)
            {
                Console.WriteLine("Both lines are equal");
            }
            else if(x<y&&x<p&&x<q)
            {
                Console.WriteLine("The value of x is greater:" + x);
            }
            else if(y<p&&y<q)
            {
                Console.WriteLine("The value of y is greater:" + y);
            }
            else if(p<q)
            {
                Console.WriteLine("The value of p is greater:" + p);
            }
            else
            {
                Console.WriteLine("The value of q is greater:" + q);
            }
            if (x > y && x >p && x > q)
            {
                Console.WriteLine("The value of x is lesser:" + x);
            }
            else if (y > p && y > q)
            {
                Console.WriteLine("The value of y is lesser:" + y);
            }
            else if (p > q)
            {
                Console.WriteLine("The value of p is lesser:" + p);
            }
            else
            {
                Console.WriteLine("The value of q is lesser:" + q);
            }


        }
    }
}
