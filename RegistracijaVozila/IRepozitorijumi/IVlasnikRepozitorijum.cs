using RegistracijaVozila.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.IRepozitorijumi
{
    public interface IVlasnikRepozitorijum
    {
        IEnumerable<Vlasnik> VratiSve();
        Vlasnik VratiPoId(int id);
        void Dodaj(Vlasnik vlasnik);
        void Obrisi(Vlasnik vlasnik);
        IEnumerable<Putnicko> MojaPutnicka(int vlasnikId);
        IEnumerable<Teretno> MojaTeretna(int vlasnikId);
    }
}
