using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_line_organization
{
    public class Equal2Lines
    {
        static double length1;
        static double length2;
        public static void CheckLength(int x1, int y1, int x2, int y2, int p1, int q1, int p2, int q2)
        {
            double length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double length2 = Math.Sqrt((p2 - p1) * (p2 - p1) + (q2 - q1) * (q2 - q1));

            if (length1.Equals(length2))
            {
                Console.WriteLine("Both lines are equals");
                Console.WriteLine("Length of both lines are equals");
            }
            else
            {
                Console.WriteLine("Both lines are not equals");
                Console.WriteLine("Length of both lines are not equals");
            }
        }
    }
}
