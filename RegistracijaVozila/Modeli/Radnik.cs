using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.Modeli
{
    public class Radnik
    {
        public int RadnikId { set; get; }
        public string Ime { set; get; }
        public string Prezime { set; get; }
        public int Godine { set; get; }
        public Organizacija Organizacija { set; get; }
        public int OrganizacijaId { set; get; }

        public override string ToString()
        {
            return RadnikId.ToString() + " " + Ime + " " + Prezime;
        }
    }
}
