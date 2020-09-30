using System;

namespace uc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double d1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            int x11 = Convert.ToInt32(Console.ReadLine());
            int x22 = Convert.ToInt32(Console.ReadLine());
            int y11 = Convert.ToInt32(Console.ReadLine());
            int y22 = Convert.ToInt32(Console.ReadLine());
            double d2 = Math.Sqrt(Math.Pow(x22 - x11, 2) + Math.Pow(y22 - y11, 2));
            if (d1==d2)
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
