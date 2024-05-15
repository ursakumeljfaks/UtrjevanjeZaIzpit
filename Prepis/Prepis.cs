using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prepis
{
    internal class Prepis
    {
        static void Main(string[] args)
        {
            PrepisTeksta("vhodna.txt");
        }

        public static void PrepisTeksta(string vhodna, string izhodna="izhod.txt")
        {
            if (File.Exists(izhodna)) throw new Exception("Ta izhodna datoteka že obstaja!");
            using (StreamReader sr = File.OpenText(vhodna))
            {
                using (StreamWriter sw = File.CreateText(izhodna)) 
                {
                    string vrstica;
                    int kateraVrstica = 1;

                    while ((vrstica = sr.ReadLine()) != null)
                    {
                        if (!(vrstica == ""))
                        {
                            kateraVrstica++;
                            sw.WriteLine($"{kateraVrstica}. {vrstica}");
                        }
                        else continue;
                    }
                }
            }
        }
    }
}
