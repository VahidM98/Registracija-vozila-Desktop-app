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
    class RegistracijaRepozitorijum : IRegistracijaRepozitorijum
    {
        private VoziloContext context;
        
        public RegistracijaRepozitorijum(VoziloContext context)
        {
            this.context = context;
        }

        public void Dodaj(Registracija registracija)
        {
            context.Registracije.Add(registracija);
        }

        public void Obrisi(Registracija registracija)
        {
            context.Registracije.Remove(registracija);
        }

        public Registracija VratiPoId(int id)
        {
            return context.Registracije.Find(id);
        }

        public IEnumerable<Registracija> VratiSve()
        {
            return context.Registracije.ToList();
        }
    }
}
