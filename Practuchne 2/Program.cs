using System;

namespace ConsoleApp45
{
    class Program
    {
        
        public delegate double SimpleDelegate(double x, double y);

        
        
            static void Main(string[] args)
            {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());

            SimpleDelegate average = GetAverage;
                Console.WriteLine(average(a, b));
                Console.ReadLine();
            }


            private static double GetAverage(double x, double y)
            {
                return (x + y) / 2;
            }
        
    }
}
