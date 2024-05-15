using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DruzabneStevilke
{
    internal class DruzabneStevilke
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Druzabne("bal123i4e7e12bed42"));
        }
        public static int Druzabne(string niz)
        {
            MatchCollection nedruzabne = Regex.Matches(niz, @"(?<!\d)\d(?!\d)");
            int vse = 0;
            HashSet<char> stevke = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < niz.Length; i++)
            {
                if (stevke.Contains(niz[i]))
                {
                    vse++;
                }
            }
            return vse - nedruzabne.Count;
        }
        
    }
}
