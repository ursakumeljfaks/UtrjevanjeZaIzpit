using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromskaStevila
{
    internal class PalindromskaStevila
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", VsaPalindromska(90, 130)));
        }

        private static bool Palindromsko(int stevilo)
        {
            string nizStevila = stevilo.ToString();
            string obrnjeno = "";

            for (int i = nizStevila.Length - 1; i  >= 0; i--) 
            {
                obrnjeno += nizStevila[i];
            }

            if (nizStevila == obrnjeno) return true;
            return false;
        }

        public static List<int> VsaPalindromska(int a, int b)
        {
            List<int> palindromska = new List<int>();
            for (int i = a; i <= b; i++)
            {
                if (Palindromsko(i)) palindromska.Add(i);
                else continue;
            }
            return palindromska;
        }
    }
}
