using RegistracijaVozila.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.IRepozitorijumi
{
    public interface ITeretnaRepozitorijum
    {
        IEnumerable<Teretno> VratiSva();
        Teretno VratiPoId(int id);
        void Dodaj(Teretno vozilo);
        void Obrisi(Teretno vozilo);
    }
}
