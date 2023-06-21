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

            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("The Length of Line for (" + x1 + "," + y1 + ") and (" + x2 + "," + y2 + ") is : " + length);
        }
    }
}
