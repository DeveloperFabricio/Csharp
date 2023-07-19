using System;
using System.Globalization;
using System.Threading.Tasks.Sources;

namespace Exercicio03
{
    class Course
    {
        static void Main(string[] args)
        {
            int a, b, c;

            String[] vet;

            vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("MENOR = " + a);
            }
            else if (b < c)
            {
                Console.WriteLine("MENOR = " + b);
            }
            else
            {
                Console.WriteLine("MENOR = " + c);
            }
        }
    }
}