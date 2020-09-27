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
    public class VlasnikRepozitorijum : IVlasnikRepozitorijum
    {

        private VoziloContext context;

        public VlasnikRepozitorijum(VoziloContext context)
        {
            this.context = context;
        }

        public void Dodaj(Vlasnik vlasnik)
        {
            context.Vlasnici.Add(vlasnik);
        }

        public void Obrisi(Vlasnik vlasnik)
        {
            context.Vlasnici.Remove(vlasnik);
        }

        public Vlasnik VratiPoId(int id)
        {
            return context.Vlasnici.Find(id);
        }

        public IEnumerable<Vlasnik> VratiSve()
        {
            return context.Vlasnici.ToList();
        }

        public IEnumerable<Putnicko> MojaPutnicka(int vlasnikId)
        {
            return context.Putnicka.Where(v => v.VlasnikId == vlasnikId).ToList();
        }
        public IEnumerable<Teretno> MojaTeretna(int vlasnikId)
        {
            return context.Teretna.Where(v => v.VlasnikId == vlasnikId).ToList();
        }
    }
}
