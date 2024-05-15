using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Baze
{
    internal class Baze
    {
        static void Main(string[] args)
        {
            string niz = @"Data Source=C:\Users\Urša\Desktop\prog3\UtrjevanjeZaIzpit\Baze\nobelDB.db";
            // ustvarimo povezavo
            SQLiteConnection povezava = new SQLiteConnection(niz);
            povezava.Open();
            // ukaz je objekt, ki po povezavi prenasa ukaze od programa k podatkovnemu viru in nazaj nosi rezultate
            SQLiteCommand ukaz = new SQLiteCommand(povezava); // poves s katero povezavo je ukaz povezan

            // izpisi vse zamgovalce, ki imajo v imenu Albert
            ukaz.CommandText = "SELECT DISTINCT winner FROM nobel WHERE winner LIKE '%Albert%'";
            // z ...DataReader preberemo rezultate pridobljene z objektom ...Command, te rezultate na ustrezen način obdelamo
            SQLiteDataReader rezultat = ukaz.ExecuteReader();
            Console.WriteLine("Vsi zadetki so:");
            while (rezultat.Read())
            {
                Console.WriteLine(rezultat[0].ToString());
            }
            // zapremo rezultate za branje
            rezultat.Close();
            Console.WriteLine();

            // izpisi vseh leto: zmagovalec, ki so dobili nagrade za mir
            ukaz.CommandText = "SELECT DISTINCT winner, yr FROM nobel WHERE subject = 'Peace'";
            rezultat = ukaz.ExecuteReader();
            while (rezultat.Read())
            {
                Console.WriteLine($"{rezultat[1]}: {rezultat[0]}");
            }
            rezultat.Close();
            povezava.Close();
        }
    }
}
