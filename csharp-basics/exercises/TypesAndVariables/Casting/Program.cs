using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            byte a = 1;
            byte b = 2;
            byte c = 3;
            byte d = 4;
            byte e = 5;
            byte sum = (byte)(a + b + c + d + e);
            Console.WriteLine(sum);
        }

        static void Second()
        {
            double a = 1;
            double b = 2;
            double c = 3;
            double d = 4.2;
            double e = 5.3d;
            double sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }
    }
}
