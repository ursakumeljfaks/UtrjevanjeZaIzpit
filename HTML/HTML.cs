using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HTML
{
    internal class HTML
    {
        static void Main(string[] args)
        {
            Prepis("vhodna.csv", "izhodna.txt");

        }

        public static void Prepis(string vhodna, string izhodna)
        {
            using (StreamReader sr = File.OpenText(vhodna))
            {
                using (StreamWriter sw = File.CreateText(izhodna))
                {
                    string vrstica;
                    sw.WriteLine("<table>");

                    //pregledamo posebej prvo vrstico, da lahko tiste, ki niso iste dolzine vrzemo ven
                    string[] prvaVrstica = sr.ReadLine().Split(',');
                    sw.WriteLine("   <tr>");
                    for (int i = 0; i < prvaVrstica.Length; i++)
                    {
                        sw.WriteLine($"      <td>{prvaVrstica[i]}</td>");
                    }
                    sw.WriteLine("   </tr>");
                    int dolzina = prvaVrstica.Length;

                    while ((vrstica = sr.ReadLine()) != null)
                    {
                        string[] posamezne = vrstica.Split(',');
                        if (posamezne.Length == dolzina)
                        {
                            sw.WriteLine("   <tr>");
                            for (int i = 0; i < posamezne.Length; i++)
                            {
                                sw.WriteLine($"      <td>{posamezne[i]}</td>");
                            }
                            sw.WriteLine("   </tr>");
                        }
                        else continue;
                        
                    }
                    sw.WriteLine("</table>");
                }
            }
        }

    }
}
