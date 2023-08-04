using System;

namespace uri1078
{
    class Course
    {
        static void Main(string[] args)
        {
            int X, resultado;

            X = int.Parse(Console.ReadLine());

            for (int i=1; i<=10; i++)
            {
                resultado = i * X;
                Console.WriteLine(i + " x " + X + " = " + resultado);
            }
        }
    }
}
