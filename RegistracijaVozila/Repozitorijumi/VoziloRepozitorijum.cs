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
    public class PutnickoRepozitorijum : IPutnickoRepozitorijum
    {
        private VoziloContext context;

        public PutnickoRepozitorijum(VoziloContext context)
        {
            this.context = context;
        }
        public void Dodaj(Putnicko vozilo)
        {
            context.Putnicka.Add(vozilo);
        }

        public void Obrisi(Putnicko vozilo)
        {
            context.Putnicka.Remove(vozilo);
        }

        public Putnicko VratiPoId(int id)
        {
            return context.Putnicka.Find(id);
        }

        public IEnumerable<Putnicko> VratiSva()
        {
            return context.Putnicka.ToList();
        }
    }
}
