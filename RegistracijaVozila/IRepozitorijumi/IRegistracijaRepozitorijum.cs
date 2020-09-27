using RegistracijaVozila.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.IRepozitorijumi
{
    public interface IRegistracijaRepozitorijum
    {
        IEnumerable<Registracija> VratiSve();
        Registracija VratiPoId(int id);
        void Dodaj(Registracija registracija);
        void Obrisi(Registracija registracija);
    }
}
