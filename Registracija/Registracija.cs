using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    public class Registracija
    {
        private string _obmocje;
        private string _registracijaAvta;

        private HashSet<string> moznaObmocja = new HashSet<string> { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };
        private string mozniZnaki = "ABCDEFGHIJKLMNOPRSTUVYWZQX0123456789";

        public Registracija(string ob, string regi)
        {
            this.Obmocje = ob;
            this.RegistracijaAvta = regi;
        }

        public string Obmocje
        {
            get { return _obmocje; }
            set
            {
                if (moznaObmocja.Contains(value)) { _obmocje = value; }
                else throw new ArgumentException("Nisi izbral pravega območja!");
            }
        }

        public string RegistracijaAvta
        {
            get { return this._registracijaAvta; }
            set
            {
                if (value.Length != 5) throw new ArgumentException("Ni ustrezna registracija, ker ni sestavljena iz 5. znakov!");
                else
                {
                    foreach (char znak in value)
                    {
                        if (!mozniZnaki.Contains(znak.ToString())) throw new ArgumentException("Neustrezen znak!");
                    }
                    this._registracijaAvta = value;

                }
            }
        }

        public override string ToString()
        {
            return $"Avto ima registersko: {Obmocje}-{RegistracijaAvta}";
        }
    }
}
