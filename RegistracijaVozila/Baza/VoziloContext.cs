using RegistracijaVozila.Modeli;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.Baza
{
    public class VoziloContext : DbContext
    {
     
        public virtual DbSet<Putnicko> Putnicka { set; get; }
        public virtual DbSet<Teretno> Teretna { set; get; }
        public  virtual DbSet<Radnik> Radnici { set; get; }
        public virtual DbSet<Vlasnik> Vlasnici { set; get; }
        public virtual DbSet<Organizacija> Organizacije { set; get; }
        public virtual DbSet<Registracija> Registracije { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Modeli.Registracija>().HasKey(r => r.RegistracijaId);
            modelBuilder.Entity<Radnik>().HasKey(ra => ra.RadnikId);
            modelBuilder.Entity<Vlasnik>().HasKey(v => v.VlasnikId);
            modelBuilder.Entity<Putnicko>().HasKey(vz => vz.PutnickoId);
            modelBuilder.Entity<Teretno>().HasKey(vz => vz.TeretnoId);
            modelBuilder.Entity<Organizacija>().HasKey(o => o.OrganizacijaId);
           // modelBuilder.Entity<Modeli.Registracija>().HasRequired(r => r.Radnik).WithOptional(ra => ra.Registracija);
            modelBuilder.Entity<Vlasnik>().Property(v => v.Ime).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Vlasnik>().Property(v => v.Prezime).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Radnik>().Property(ra => ra.Ime).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Radnik>().Property(ra => ra.Prezime).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Radnik>().Property(ra => ra.Godine).IsOptional();
            modelBuilder.Entity<Organizacija>().Property(o => o.Naziv).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Organizacija>().Property(o => o.Grad).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Organizacija>().Property(o => o.Ulica).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Modeli.Registracija>().Property(r => r.Cena).IsRequired();
            modelBuilder.Entity<Modeli.Registracija>().Property(r => r.tipVozila).IsRequired();
            modelBuilder.Entity<Modeli.Registracija>().Property(r => r.Datum).IsRequired();
            modelBuilder.Entity<Putnicko>().Property(vz => vz.Proizvodjac).HasMaxLength(20).IsRequired();
            modelBuilder.Entity <Putnicko> ().Property(vz => vz.Tip).HasMaxLength(20).IsRequired();
            modelBuilder.Entity < Putnicko > ().Property(vz => vz.GodProizvodnje).IsRequired();
            modelBuilder.Entity<Putnicko>().Property(vz => vz.Boja).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Teretno>().Property(vz => vz.Proizvodjac).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Teretno>().Property(vz => vz.Tip).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Teretno>().Property(vz => vz.GodProizvodnje).IsRequired();
            modelBuilder.Entity<Teretno>().Property(vz => vz.Boja).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Teretno>().Property(vz => vz.Nosivost).IsRequired();
            modelBuilder.Entity<Putnicko>().Property(vz => vz.Snaga).IsRequired();










        }
    }
}
