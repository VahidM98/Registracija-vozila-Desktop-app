using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.IRepozitorijumi
{
    public interface IUnitOfWork
    {
        IPutnickoRepozitorijum Vozila { get;}
        ITeretnaRepozitorijum Teretna { get; }
        IVlasnikRepozitorijum Vlasnici { get; }
        IRadnikRepozitorijum Radnici { get; }
        IOrganizacijaRepozitorijum Organizacije { get; }
        IRegistracijaRepozitorijum Registracije { get; }
        void Sacuvaj();
    }
}
