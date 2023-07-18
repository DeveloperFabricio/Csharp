using System;
using System.Globalization;

namespace uri1036
{
    class Course
    {
        static void Main(string[] args)
        {
            double A, B, C, delta ,R1, R2;

            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            delta = Math.Pow (B, 2.0) - 4 * A * C;

            R1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
            R2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

            if (A == 0 || delta < 0.0) 
            {
                Console.WriteLine("Impossivel calcular");
                
            }
            else
            {
                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}