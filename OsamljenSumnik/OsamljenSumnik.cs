using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OsamljenSumnik
{
    internal class OsamljenSumnik
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OsamljeniSumniki("ŠpelčččicažraškaŽ"));
        }

        public static int OsamljeniSumniki(string niz)
        {
            MatchCollection osamljeni = Regex.Matches(niz, @"(?<![ČčŽžŠš])[ČčŽžŠš](?![ČčŽžŠš])");
            return osamljeni.Count;
        }
    }
}
