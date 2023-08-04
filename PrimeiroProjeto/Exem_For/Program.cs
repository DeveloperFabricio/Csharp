using System;
using System.Diagnostics;

namespace Exem_For
{
    class Course
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            N = int.Parse(Console.ReadLine());

            soma = 0;
            for ( int i=1; i<= N; i++ )
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}