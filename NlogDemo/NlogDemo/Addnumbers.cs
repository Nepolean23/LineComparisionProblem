using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    class Addnumbers
    {
        public static void addnumbers()
        {
            Console.WriteLine("Hello World!");
            int result = AddNumbers.Sum(12, 0);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
