using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnomestnaStevila
{
    internal class EnomestnaStevila
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KolikoEnomestnih("12.3.789.abc134"));
            Console.WriteLine(KolikoEnomestnih("D12"));
        }

        public static int KolikoEnomestnih(string niz)
        {
            MatchCollection ujemanj = Regex.Matches(niz, @"(?<!\d)\d(?!\d)");
            return ujemanj.Count;
        }
    }
}
