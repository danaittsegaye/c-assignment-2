//fibonacci series upto 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, sum;
            sum = 0;
            Console.Write(" " + n1 + "  " + n2 + "  ");
            sum = n1 + n2;
            while (sum <= 100)
            {
                Console.Write(sum + "  ");
                n1 = n2;
                n2 = sum;
                sum = n1 + n2;
            }
        }
    }
}
