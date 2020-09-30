using System;

sing System;

namespace uc3
{
    class Program
    {
        static string compareTomethod(int d1, int d2)
        {
            // Calculating distance
            if (d1 < d2)
            {
                Console.WriteLine("d1 is greater than d2");
            }
            else if (d1 < d2)
            {
                Console.WriteLine("d1 is lesser than d2");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }

        // Driver code 
        public static void Main(string[] args)
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
            compareTomethod(d1, d2);
        }
    }
}

