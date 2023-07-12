using System;
using System.Globalization;

namespace uri1011
{
    class Course
    {
        static void Main(string[] args)
        {
            double X, pi, volume;

            X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pi = 3.14159;
            volume = 4 / 3.0 * pi * ( X * X * X);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}