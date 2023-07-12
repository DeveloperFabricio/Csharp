using System;

namespace curso
{
    class Program
    {
        private static string X;

        static void Main(string[] args)
        {

            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            PROD = A * B;

            Console.WriteLine("PROD = " + PROD);

        }
    }
}