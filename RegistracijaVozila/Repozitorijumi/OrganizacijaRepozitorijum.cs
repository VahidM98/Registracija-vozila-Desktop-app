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
    public class OrganizacijaRepozitorijum : IOrganizacijaRepozitorijum
    {
        private VoziloContext context;

        public OrganizacijaRepozitorijum(VoziloContext context)
        {
            this.context = context;
        }

        public void Dodaj(Organizacija organizacija)
        {
            context.Organizacije.Add(organizacija);
        }

        public void Obrisi(Organizacija organizacija)
        {
            context.Organizacije.Remove(organizacija);
        }

        public Organizacija VratiPoId(int id)
        {
            return context.Organizacije.Find(id);
        }

        public IEnumerable<Organizacija> VratiSve()
        {
            return context.Organizacije.ToList();
        }
        
        public IEnumerable<Radnik> radniciOrg(int orgId)
        {
            return context.Radnici.Where(r => r.OrganizacijaId == orgId).ToList();
        }
    }
}
