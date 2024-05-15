using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoprnaSedmica
{
    internal class ZoprnaSedmica
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 1, 7, 10, 77, 88, 107, 49, 21 };
            int[] tab2 = { 0, 1, 2, 3 };
            int[] tab3 = { 0, -7, -23, -77, 12, 21 };
            Console.WriteLine(string.Join(", ", Sedmice(tab1)));
            Console.WriteLine(string.Join(", ", Sedmice(tab2)));
            Console.WriteLine(string.Join(", ", Sedmice(tab3)));

        }

        /// <summary>
        /// za dano tabelo celih stevil stevila, vrne tabelo dveh celih stevil [stevila, deljiva s 7; vsoto preostalih stevil]
        /// </summary>
        /// <param name="stevila">tabela celih stevil</param>
        /// <returns>tabelo celih stevil</returns>
        public static int[] Sedmice(int[] stevila)
        {
            int vsota = 0;  
            int deljiva = 0;
            int[] nova = new int[2];

            for (int i = 0; i < stevila.Length; i++) 
            {
                if (stevila[i] % 7 == 0) deljiva++;
                else vsota += stevila[i];
            }

            nova[0] = vsota;
            nova[1] = deljiva;

            return nova;
        }
    }
}
