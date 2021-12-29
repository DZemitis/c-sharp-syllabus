using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new GravityCal();
            x.CalcFinalPosition();
            Console.WriteLine(x.PrintObjectFall());
        }
    }
}