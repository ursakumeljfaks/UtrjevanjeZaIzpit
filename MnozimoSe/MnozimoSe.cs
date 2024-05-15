using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnozimoSe
{
    internal class MnozimoSe
    {
        static void Main(string[] args)
        {
            Zmnozek("vhodna.txt", "izhodna.txt");

        }

        public static void Zmnozek(string vhodna, string izhodna)
        {
            using (StreamReader sr = File.OpenText(vhodna)) 
            {
                using (StreamWriter sw = File.CreateText(izhodna))
                {
                    string vrstica;
                    int stevec = 1;
                    int imenovalec = 1;

                    while ((vrstica = sr.ReadLine()) != null)
                    {
                        string[] posamezna = new string[vrstica.Length];
                        posamezna = vrstica.Split('/');
                        
                        if (posamezna.Length == 1) stevec *= int.Parse(posamezna[0]);
                        else
                        {
                            stevec *= int.Parse(posamezna[0]);
                            imenovalec *= int.Parse(posamezna[1]);
                        }
                    }

                    if (stevec > 0 && imenovalec < 0) sw.WriteLine($"-{stevec}/{Math.Abs(imenovalec)}");
                    else sw.WriteLine(stevec + "/" + imenovalec);

                }
            }

        }

    }
}
