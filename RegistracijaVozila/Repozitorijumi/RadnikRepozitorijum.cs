using RegistracijaVozila.Baza;
using RegistracijaVozila.IRepozitorijumi;
using RegistracijaVozila.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.Repozitorijumi
{
    public class RadnikRepozitorijum : IRadnikRepozitorijum
    {
        private VoziloContext context;

        public RadnikRepozitorijum(VoziloContext context)
        {
            this.context = context;
        }

        public void Dodaj(Radnik radnik)
        {
            context.Radnici.Add(radnik);
        }

        public void Obrisi(Radnik radnik)
        {
            context.Radnici.Remove(radnik);
        }

        public Radnik VratiPoId(int id)
        {
            return context.Radnici.Find(id);
        }

        public IEnumerable<Radnik> VratiSve()
        {
            return context.Radnici.ToList();
        }
    }
}
