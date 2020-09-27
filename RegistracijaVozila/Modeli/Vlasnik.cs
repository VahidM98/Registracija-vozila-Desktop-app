using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.Modeli
{
    public class Vlasnik
    {
        public Vlasnik()
        {
            Vozila = new List<Vozilo>();
        }
        public int VlasnikId { set; get; }
        public string Ime { set; get; }
        public string Prezime { set; get;}
        public ICollection<Vozilo> Vozila { set; get; }

        public override String ToString()
        {
            return VlasnikId.ToString() + ' ' + Ime + ' ' + Prezime; 
        }
    }
}
