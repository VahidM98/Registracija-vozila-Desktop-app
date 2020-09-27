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
    class TeretnoRepozitorijum : ITeretnaRepozitorijum
    {
        private VoziloContext context;

        public TeretnoRepozitorijum(VoziloContext context)
        {
            this.context = context;
        }
        public void Dodaj(Teretno vozilo)
        {
            context.Teretna.Add(vozilo);
        }

        public void Obrisi(Teretno vozilo)
        {
            context.Teretna.Remove(vozilo);
        }

        public Teretno VratiPoId(int id)
        {
            return context.Teretna.Find(id);
        }

        public IEnumerable<Teretno> VratiSva()
        {
            return context.Teretna.ToList();
        }
    }
}
