using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatotekoBerezOklepajev
{
    internal class DatotekoBerezOklepajev
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PravilniOklepaji("To )( ni prav. "));
            BrezOklepajev("vhodna.txt", "izhodna.txt");
        }

        public static bool PravilniOklepaji(string vrstica)
        {
            int oklepaj = 0;
            int zaklepaj = 0;

            foreach (char znak in vrstica)
            {
                if (zaklepaj < 0 && oklepaj == 0) return false;
                else if (znak == '(') oklepaj++;
                else if (znak == ')') zaklepaj--;
            }

            if (oklepaj + zaklepaj == 0) return true;
            else return false;
        }

        public static string OdstraniBesedo(string vrstica)
        {
            string novaVrstica = "";
            bool pavza = false;
            foreach (char znak in vrstica)
            {
                if (znak == '(') pavza = true;
                if (znak == ')') pavza = false;
                else if (pavza is false)
                {
                    novaVrstica += znak;
                }

            }
            return novaVrstica;
        }

        public static void BrezOklepajev(string vhodna, string izhodna)
        {
            using (StreamReader sr = new StreamReader(vhodna))
            {
                using (StreamWriter sw  = new StreamWriter(izhodna))
                {
                    string vrstica;

                    while ((vrstica = sr.ReadLine()) != null)
                    {
                        if (!PravilniOklepaji(vrstica)) sw.WriteLine("NAPAKA");
                        else sw.WriteLine($"{OdstraniBesedo(vrstica)}");
                    }
                }
            }
        }
    }
}
