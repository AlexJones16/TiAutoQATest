using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BootcampTestTask
{
    class TestTask
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            Triangle.GetPoints(t);
            Triangle.GetSideLength(t);
            Console.ReadLine();
        }
    }
}
