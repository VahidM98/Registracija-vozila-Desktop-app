using RegistracijaVozila.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.IRepozitorijumi
{
    public interface IPutnickoRepozitorijum
    {
        IEnumerable<Putnicko> VratiSva();
       Putnicko VratiPoId(int id);
        void Dodaj(Putnicko vozilo);
        void Obrisi(Putnicko vozilo);
    }
}
