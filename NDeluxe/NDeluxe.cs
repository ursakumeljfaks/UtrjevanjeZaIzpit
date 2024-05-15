using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NDeluxe
{
    internal class NDeluxe
    {
        static void Main(string[] args)
        {
            string[] blebetanje = { "bla", "blo", "bli" };
            Console.WriteLine(Vrni(blebetanje, 1));
            Console.WriteLine(Vrni(blebetanje, -1));


        }


        public static T Vrni<T>(T[] tabela, int n)
        {
            T vrni = tabela[0];
            if (n > 0)
            {
                if (n > tabela.Length) throw new Exception($"Tabela ima le {tabela.Length} elementov!");
                return tabela[n-1];
            }
            else
            {
                if (Math.Abs(n) > tabela.Length) throw new Exception($"Tabela ima le {tabela.Length} elementov!");
                return tabela[tabela.Length + n];
            }

        }

    }
}
