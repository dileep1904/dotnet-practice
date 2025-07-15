using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter a number:");
            a=int.Parse(Console.ReadLine());
            Console.Write("Enter b number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("number before swapping:" + a +","+ b);

            c = a;
            a=b;
            b=c;
            Console.WriteLine("swapped numbers:");
            Console.WriteLine("Value of a:" + a);
            Console.WriteLine("Value of b:" + b); 
            Console.Read();



        }
    }
}
