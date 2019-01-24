using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, area;
            double a, b, c;


            Console.WriteLine("Side #1");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Side #2");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Side #3");
            c = double.Parse(Console.ReadLine());

            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));


            Console.WriteLine("The area is {0}", area);
            Console.ReadLine();
        }
    }
}
