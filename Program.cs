using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulačkq
{
    class Program
    {
        static void Main(string[] args)
        {
            double cislo1, cislo2, vysledek = 0;
            string operace;

            Console.WriteLine("zadejte první číslo");
            cislo1 = double.Parse(Console.ReadLine());
            Console.WriteLine("zadejte znaménko operace");
            operace = Console.ReadLine();
            Console.WriteLine("zadejte druhé číslo");
            cislo2 = double.Parse(Console.ReadLine());


            if (operace == "+")
            {
                vysledek = cislo1 + cislo2;
            }

            else if (operace == "-")
            {
                vysledek = cislo1 - cislo2;
            }

            else if (operace == "*")
            {
                vysledek = cislo1 * cislo2;
            }

            else if (operace == "/")
            {
                vysledek = cislo1 / cislo2;
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("vysledek: " + vysledek);
            Console.ReadKey();
        }
    }
}
