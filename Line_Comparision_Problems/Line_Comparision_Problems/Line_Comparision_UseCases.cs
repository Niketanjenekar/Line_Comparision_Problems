using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision_Problems
{
    public class Line_Comparision_UseCases
    {
        public static void Lines()
        {
            Console.WriteLine("Please enter the first coordinate x1 :");

            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the first coordinate y1 :");

            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the first coordinate x2 :");

            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the first coordinate y2 :");

            double y2 = Convert.ToDouble(Console.ReadLine());

            double Length_One = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("The Length of Line for (" + x1 + "," + y1 + ") and (" + x2 + "," + y2 + ") is : " + Length_One);

            Console.WriteLine("Please enter the first coordinate x3 :");

            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the first coordinate y3 :");

            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the first coordinate x4 :");

            int x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the first coordinate y4 :");

            int y4 = Convert.ToInt32(Console.ReadLine());

            double Length_Two = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);

            Console.WriteLine("The Length of Line for (" + x3 + "," + y3 + ") and (" + x4 + "," + y4 + ") is : " + Length_Two);

            //If-Else loop for Comparing Both the lines

            if (Length_One == Length_Two)
            {
                Console.WriteLine("Both The Lines are of Equal Length");

            }
            else
            {
                Console.WriteLine(" The Lines are not of Equal Length");
            }
        }
    }
}
