using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
    
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----Equivalência------");
            Console.ResetColor();
            Console.WriteLine("digite um número:");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double cm = m * 100;
            double km = m / 1000;
            Console.WriteLine($"{cm} cm");
            Console.WriteLine($"{m} m");
            Console.WriteLine($"{km}km");

        }
    }
}
