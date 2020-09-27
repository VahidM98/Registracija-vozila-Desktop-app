using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaVozila.Modeli
{
    public class Registracija
    {
        public int RegistracijaId { set; get; }
        public int Cena { set; get; }
        public string Datum { set; get; }
        public Radnik Radnik { set; get; }
        public int RadnikId { set; get; }
        public int VoziloId { set; get; }
        public string tipVozila { set; get; }

    }
}
