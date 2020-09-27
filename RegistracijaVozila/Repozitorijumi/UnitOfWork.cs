using RegistracijaVozila.Baza;
using RegistracijaVozila.IRepozitorijumi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.Repozitorijumi
{
    public class UnitOfWork : IUnitOfWork
    {
        private VoziloContext context;
        private RadnikRepozitorijum radnici;
        private PutnickoRepozitorijum vozila;
        private VlasnikRepozitorijum vlasnici;
        private OrganizacijaRepozitorijum organizacije;
        private RegistracijaRepozitorijum registracije;
        private TeretnoRepozitorijum teretna; 

        public UnitOfWork(VoziloContext context)
        {
            this.context = context;
        }

        public IPutnickoRepozitorijum Vozila
        {
            get
            {
                return vozila ?? (vozila = new PutnickoRepozitorijum(context));
            }
        }
        public ITeretnaRepozitorijum Teretna
        {
            get
            {
                return teretna ?? (teretna = new TeretnoRepozitorijum(context));
            }
        }

        public IVlasnikRepozitorijum Vlasnici
        {
            get
            {
                return vlasnici ?? (vlasnici = new VlasnikRepozitorijum(context));
            }
        }

        public IRadnikRepozitorijum Radnici
        {
            get
            {
                return radnici ?? (radnici = new RadnikRepozitorijum(context));
            }
        }

        public IOrganizacijaRepozitorijum Organizacije
        {
            get
            {
                return organizacije ?? (organizacije = new OrganizacijaRepozitorijum(context));
            }
        }

        public IRegistracijaRepozitorijum Registracije
        {
            get
            {
                return registracije ?? (registracije = new RegistracijaRepozitorijum(context));
            }
        }

        public void Sacuvaj()
        {
            context.SaveChanges();
        }
    }

}
