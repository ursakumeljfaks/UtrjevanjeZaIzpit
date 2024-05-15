using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IzpisTabele
{
    internal class IzpisTabele
    {
        static void Main(string[] args)
        {
            int[] tabela1 = { 12, 5, 6, 78, 3, 5, 6, 21, 434, 56, 42, 7 };
            string[] tabela2 = { "Ursa", "Neja", "Janze", "Tone" };
            bool[] tabela3 = { true, false, true, false, true, false, true, false };

            Izpis(tabela1, 5, " : ");
            Console.WriteLine();
            Izpis(tabela2, 3, " | ");
            Console.WriteLine();
            Izpis(tabela3, 4, " + ");

            Console.ReadKey();
        }

        public static void Izpis<T>(T[] tab, int n, string vmes)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
                if ((i + 1) % n == 0 || i == tab.Length - 1)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(vmes);
                }
            }
        }
    }
}
