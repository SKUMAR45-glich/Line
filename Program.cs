using System;

namespace uc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int x2 = 2;
            int y1 = 3;
            int y2 = 4;
            double d1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            int x11 = 2;
            int x22 = 3;
            int y11 = 4;
            int y22 = 5;
            double d2 = Math.Sqrt(Math.Pow(x22 - x11, 2) + Math.Pow(y22 - y11, 2));
            if (d1 == d2)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
