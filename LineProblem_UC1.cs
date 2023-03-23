using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProblemObject
{
    public class LineProblem_UC1
    {
        int x1, x2, y1, y2;
        double Length;
        
        public void SolveTheProblem()
        {
            Console.WriteLine("Enter the x-cordinate of point 1 : x1");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the x-cordinate of point 2 : x2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 1 : y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 2 : y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            Length = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));

            Console.WriteLine("Distance between two points: " + "(" + x1 + "," + y1 + ")" + "(" + x2 + "," + y2 + ") is :" + Length);

        }
    }
}
