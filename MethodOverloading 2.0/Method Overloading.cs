using System;

namespace MethodOverloading_2._0
{
    internal class Program
    {
        static int Method(int x, int y)
        {
            return x + y;
        }

        static double Method(double x, double y)
        {
            return x + y;
        }

        static string Method(string x)
        {
            return x;
        }

        static void Main(string[] args)
        {
            int myNum1 = Method(10, 11);
            double myNum2 = Method(6.9, 4.2);
            string myName = Method("Made by: Adrian");
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
            Console.WriteLine(myName);
        }
    }
}
