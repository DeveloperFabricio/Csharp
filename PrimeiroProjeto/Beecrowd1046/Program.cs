using System;
using System.Globalization;

namespace uri1046
{
    class Course
    {
        static void Main(string[] args)
        {
            int x, y, duracao;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            if(x < y)
            {
                duracao = y - x;
            }
            else
            {
                duracao = 24 - x + y;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
