using System;
using System.Globalization;

namespace uri1037
{
    class Course
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (X < 0.0 || X > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (X <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (X <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (X <= 75.0) 
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}