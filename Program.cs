using System;

namespace Metod_uppgift
{
    class Program
    {
            public static void Main()
            {
                double radie = 2.4;
                Console.WriteLine("Cirkelns omkrets: " + CirkelOmkrets(radie));
                Console.WriteLine("Cirkelns area: " + CirkelArea(radie));
            }

            static double CirkelOmkrets(double r)
            {
                double o = r * Math.PI;
                return o;
            }
            static double CirkelArea(double r)
            {
            double a = r * r * Math.PI;
            return a;
            }
        
    }
}
