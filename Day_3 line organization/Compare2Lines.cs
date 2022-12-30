using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_line_organization
{
    public class Compare2Lines
    {
        public static void ComparisonOfTwoLengths()
        {
            // int leng1 = 43;
            //int leng2 = 35;
            //Console.WriteLine(leng1.CompareTo(leng2));

            double length1 = 0;
            double length2 = 0;

            Console.WriteLine("enter x1,y1,x2,y2 are the length1");
            double x1 = Convert.ToInt32(Console.ReadLine());    
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            length1 = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

            Console.WriteLine("enter p1,q1,p2,q2 are the length1");
            double p1 = Convert.ToInt32(Console.ReadLine());
            double q1 = Convert.ToInt32(Console.ReadLine());
            double p2 = Convert.ToInt32(Console.ReadLine());
            double q2 = Convert.ToInt32(Console.ReadLine());

            length2 = Math.Sqrt((Math.Pow((p2 - p1), 2) + Math.Pow((q2 - q1), 2)));
        }
    }
}
