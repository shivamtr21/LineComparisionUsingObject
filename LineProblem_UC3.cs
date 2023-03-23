using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProblemObject
{
    public class LineProblem_UC3
    {
        int x1, x2, y1, y2, x3, x4, y3, y4;
        double Length1, Length2;

        public void SolveTheProblem()
        {

            //for length 1

            Console.WriteLine("Enter the x-cordinate of point 1 : x1");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the x-cordinate of point 2 : x2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 1 : y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 2 : y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            Length1 = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));

            Console.WriteLine("Distance between two points: " + "(" + x1 + "," + y1 + ")" + "(" + x2 + "," + y2 + ") is :" + Length1);


            //For length 2


            Console.WriteLine("Enter the x-cordinate of point 1 : x3");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the x-cordinate of point 2 : x4");
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 1 : y3");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 2 : y4");
            y4 = Convert.ToInt32(Console.ReadLine());

            Length2 = Math.Sqrt(((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3)));

            Console.WriteLine("Distance between two points: " + "(" + x3 + "," + y3 + ")" + "(" + x4 + "," + y4 + ") is :" + Length2);

            if (Length1 == Length2)
            {
                Console.WriteLine("Both Line are equal");
            }
            else
            {
                Console.WriteLine("Both Line Are not equal");


                if(Length1 > Length2)
                {
                    Console.WriteLine("Length 1 is greater than Length 2");
                }
                else
                {
                    Console.WriteLine("Length 2 is greater than Length 1");
                }
            }

        }
    }
}
