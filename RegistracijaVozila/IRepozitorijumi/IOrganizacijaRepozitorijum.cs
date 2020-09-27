using RegistracijaVozila.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.IRepozitorijumi
{
    public interface IOrganizacijaRepozitorijum
    {
        IEnumerable<Organizacija> VratiSve();
        Organizacija VratiPoId(int id);
        void Dodaj(Organizacija organizacija);
        void Obrisi(Organizacija organizacija);
        IEnumerable<Radnik> radniciOrg(int orgId);
    }
}
