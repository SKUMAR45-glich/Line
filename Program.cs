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
            Console.WriteLine(d1);
        }
    }
}
