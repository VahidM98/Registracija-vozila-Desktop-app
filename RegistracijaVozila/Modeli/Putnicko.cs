using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.Modeli
{
    public class Putnicko 
    {
        public int PutnickoId { set; get; }
        public string Proizvodjac { set; get; }
        public string Tip { set; get; }
        public int GodProizvodnje { set; get; }
        public float Snaga
        {
            set; get;
        }
        public string Boja { set; get; }
        public Registracija Registracija { set; get; }
        public Vlasnik Vlasnik { set; get; }
        public int VlasnikId { set; get; }

        public override string ToString()
        {
            return PutnickoId.ToString() + " " + Proizvodjac;
        }

    }
}
