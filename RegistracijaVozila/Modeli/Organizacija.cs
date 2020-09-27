using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.Modeli
{
    public class Organizacija
    {
        public Organizacija()
        {
            Radnici = new List<Radnik>();
        }
        public int OrganizacijaId { set; get; }
        public string Naziv { set; get; }
        public string Grad { set; get; }
        public string Ulica { set; get; }
        public ICollection<Radnik> Radnici { set; get; }

        public override string ToString()
        {
            return OrganizacijaId.ToString() + " " +  Naziv;
        }
    }
}
