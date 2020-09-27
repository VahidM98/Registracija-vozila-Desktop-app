using RegistracijaVozila.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.IRepozitorijumi
{
    public interface IRadnikRepozitorijum
    {
        IEnumerable<Radnik> VratiSve();
        Radnik VratiPoId(int id);
        void Dodaj(Radnik radnik);
        void Obrisi(Radnik radnik);
    }
}
