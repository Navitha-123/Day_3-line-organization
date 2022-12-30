using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_line_organization
{
    public class LengthOfTwoLines
    {
       public static void calcength()
        {
            double leng = 0;

            Console.WriteLine("cal the length of two point x and y co-ordinates:\n");

            Console.WriteLine("enter x1  value of first point");
            double x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter y1  value of first point");
            double y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter x2  value of first point");
            double x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter y2  value of first point");
            double y2 = Convert.ToInt32(Console.ReadLine());

            double Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(Length);
        }
    }
}
