using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obracamo
{
    internal class Obracamo
    {
        static void Main(string[] args)
        {
            Obrni("vhodna.txt", "izhodna.txt");

        }

        private static string NovaBeseda(string beseda)
        {
            beseda = beseda.Substring(1);
            string nova = "";
            for (int i = beseda.Length - 1; i >= 0; i--)
            {
                nova += beseda[i];
            }
            return nova;
        }

        public static void Obrni(string imeVhod, string imeIzhod)
        {
            using (StreamReader sr =  File.OpenText(imeVhod))
            {
                using (StreamWriter sw = File.CreateText(imeIzhod))
                {
                    string vrstica;

                    while ((vrstica = sr.ReadLine()) != null)
                    {
                        StringBuilder novaVrstica = new StringBuilder();
                        string[] posamezne = vrstica.Split(' ');
                        
                        for (int i = 0; i < posamezne.Length; i++)
                        {
                            if (posamezne[i].StartsWith("-")) novaVrstica.Append($"{NovaBeseda(posamezne[i])} ");
                            else if (!string.IsNullOrWhiteSpace(posamezne[i])) novaVrstica.Append($"{posamezne[i]} ");
                        }
                        sw.WriteLine(novaVrstica.ToString().TrimEnd());
                    }
                }
            }
        }

    }
}
