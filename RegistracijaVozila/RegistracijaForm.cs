using RegistracijaVozila.Baza;
using RegistracijaVozila.Modeli;
using RegistracijaVozila.Repozitorijumi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistracijaVozila
{
    public partial class RegistracijaForm : MetroFramework.Forms.MetroForm
    {
        private UnitOfWork unit;
        private int idSelekt;
        private int idV;
        private List<string> radnici = new List<string>();
        private List<string> vozilaP = new List<string>();
        private List<string> vozilaT = new List<string>();
        private string tip = "Putnicko";
        public RegistracijaForm()
        {
            InitializeComponent();
            var context = new VoziloContext();
            unit = new UnitOfWork(context);
            dgvRegistracije.DataSource = unit.Registracije.VratiSve();
            var radSvi = unit.Radnici.VratiSve();
            var vozSva = unit.Vozila.VratiSva();
            var vozTSva = unit.Teretna.VratiSva();

            foreach(var p in vozSva)
            {
                vozilaP.Add(p.ToString());
            }

            foreach (var t in vozTSva)
            {
                vozilaT.Add(t.ToString());
            }

            foreach (var r in radSvi)
            {
                radnici.Add(r.ToString());
            }

            cmbVozila.DataSource = vozSva;
            cmbRadnici.DataSource = radnici;

        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                var nova = new Registracija();
                nova.RadnikId = int.Parse(cmbRadnici.Text.Split(' ')[0]);
                nova.VoziloId = int.Parse(cmbVozila.Text.Split(' ')[0]);
                nova.Cena = int.Parse(txtCena.Text);
                nova.Datum = dtpDatum.Value.Date.ToString();
                nova.tipVozila = tip;

              //  Console.WriteLine(nova.ToString());

               unit.Registracije.Dodaj(nova);
               unit.Sacuvaj();

               MessageBox.Show("Registracija dodata.");
               dgvRegistracije.DataSource = unit.Registracije.VratiSve();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            cmbVozila.DataSource = vozilaP;
            tip = "Putnicko";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            cmbVozila.DataSource = vozilaT;
            tip = "Teretno";
        }

        private void dgvRegistracije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var ind = e.RowIndex;
                idSelekt = int.Parse(dgvRegistracije[5, ind].Value.ToString());
                var tipN = dgvRegistracije[6, ind].Value.ToString();

                var vlasnik = unit.Vlasnici.VratiPoId(idSelekt);
                Putnicko p;
                Teretno t;
                if (tipN == "Putnicko")
                {
                    p = unit.Vozila.VratiPoId(idSelekt);
                    lblVoz.Text = "Selektovano vozilo:";
                    lblVoz.Text = "Selektovano vozilo: " + p.ToString();
                    var vid = p.VlasnikId;
                    var vl = unit.Vlasnici.VratiPoId(vid);

                    lblVlasnik.Text = "Vlasnik odabranog automobila:";
                    lblVlasnik.Text = "Vlasnik odabranog automobila:" + vl.ToString();
                }
                else
                {
                    t = unit.Teretna.VratiPoId(idSelekt);
                    lblVoz.Text = "Selektovano vozilo:";
                    lblVoz.Text = "Selektovano vozilo: " + t.ToString();

                    var vid = t.VlasnikId;
                    var vl = unit.Vlasnici.VratiPoId(vid);

                    lblVlasnik.Text = "Vlasnik odabranog automobila:";
                    lblVlasnik.Text = "Vlasnik odabranog automobila:" + vl.ToString();
                }
                
           


            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska.");
            }
        }
    }
}
