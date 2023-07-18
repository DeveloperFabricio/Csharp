using System;

namespace teste_ec
{
class Course
{
    static void Main(string[] args)
    {

        int horas;

        Console.WriteLine("Quantas horas?");
        horas = int.Parse(Console.ReadLine());

        if (horas < 12)
        {
            Console.WriteLine("Bom dia!");
        }
        else if (horas < 18)
        {
            Console.WriteLine("Boa Tarde!");
        }
        else
        {
            Console.WriteLine("Boa Noite!");
        }
            
        Console.ReadLine();
    }
}
}