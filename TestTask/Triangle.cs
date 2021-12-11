using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BootcampTestTask
{
    class Triangle : Point
    {
        public static void GetPoints(Triangle t)
        {
        link1:
            try
            {
                Console.Write("Enter coordinate x of dot A: ");
                t.PointA_x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter coordinate y of dot A: ");
                t.PointA_y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter coordinate x of dot B: ");
                t.PointB_x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter coordinate y of dot B: ");
                t.PointB_y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter coordinate x of dot C: ");
                t.PointC_x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter coordinate y of dot C: ");
                t.PointC_y = Convert.ToInt32(Console.ReadLine());
                if (isPointsNull(t.PointA_x, t.PointA_y, t.PointB_x, t.PointB_y, t.PointC_x, t.PointC_y) == true)
                    goto link1;
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the correct value for the coordinate of the point");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                goto link1;
            }
            bool isPointsNull(double ax, double ay, double bx, double by, double cx, double cy)
            {
                if (ax.Equals(ay) & bx.Equals(by) & cx.Equals(cy))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points coordinates must be different from each other");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    return true;
                }
                else return false;
            }
        }
        public static void GetSideLength(Triangle t)
        {
            Console.WriteLine();
            double AB_Length = Math.Sqrt(Math.Pow((t.PointB_x - t.PointA_x), 2) + Math.Pow((t.PointB_y - t.PointA_y), 2));
            double BC_Length = Math.Sqrt(Math.Pow((t.PointC_x - t.PointB_x), 2) + Math.Pow((t.PointC_y - t.PointB_y), 2));
            double AC_Length = Math.Sqrt(Math.Pow((t.PointC_x - t.PointA_x), 2) + Math.Pow((t.PointC_y - t.PointA_y), 2));
            Console.WriteLine($"Length of AB is: '{AB_Length}'");
            Console.WriteLine($"Length of BC is: '{BC_Length}'");
            Console.WriteLine($"Length of AC is: '{AC_Length}'");
            Console.WriteLine();

            isEquilateral(AB_Length, BC_Length, AC_Length);
            isIsosceles(AB_Length, BC_Length, AC_Length);
            isRectangular(AB_Length, BC_Length, AC_Length);

            Console.WriteLine();
            double perimeter = GetPerimeter(AB_Length, BC_Length, AC_Length);
            Console.WriteLine("Perimeter: {0}", perimeter);
            ParityNumbers(perimeter);

        }
        private static void isEquilateral(double ab, double bc, double ac)
        {
            if (ab.Equals(bc) & ab.Equals(ac) & bc.Equals(ac))
            {
                Console.WriteLine("Triangle is 'Equilateral'");
            }
            else { Console.WriteLine("Triangle is NOT 'Equilateral'"); }
        }
        private static void isIsosceles(double ab, double bc, double ac)
        {
            if (ab.Equals(bc) || ab.Equals(ac) || bc.Equals(ac))
            {
                Console.WriteLine("Triangle is 'Isosceles'");
            }
            else { Console.WriteLine("Triangle is NOT 'Isosceles'"); }
        }
        private static void isRectangular(double ab, double bc, double ac)
        {
            double ab2 = Math.Pow((ab), 2);
            double bc2 = Math.Pow((bc), 2);
            double ac2 = Math.Pow((ac), 2);
            double sum = ab2 + ac2;

            if ((bc2 - sum) <= 1)
            {
                Console.WriteLine("Triangle is 'Right'");
            }
            else { Console.WriteLine("Triangle is NOT 'Right'"); }
        }
        private static double GetPerimeter(double ab, double bc, double ac)
        {
            double perimeter = ab + bc + ac;
            return perimeter;
        }
        private static void ParityNumbers(double perimeter)
        {
            int perToRound = Convert.ToInt32(Math.Round(perimeter));
            Console.WriteLine();
            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter: ");
            for (int i = 0; i <= perToRound; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
