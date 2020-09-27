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
    public partial class VlasnikForm : MetroFramework.Forms.MetroForm
    {
        private UnitOfWork unit;
        int idSelekt = 0;
        public VlasnikForm()
        {
            InitializeComponent();
            var context = new VoziloContext();
            unit = new UnitOfWork(context);
            dgvVlasnici.DataSource = unit.Vlasnici.VratiSve();
        }

        private void VlasnikForm_Load(object sender, EventArgs e)
        {

        }

        private void lblBrisanje_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                var ime = txtIme.Text;
                var prezime = txtPrezime.Text;
                var novi = new Vlasnik();
                novi.Ime = ime;
                novi.Prezime = prezime;
                this.unit.Vlasnici.Dodaj(novi);
                this.unit.Sacuvaj();
                MessageBox.Show("Vlasnik dodat");
                dgvVlasnici.DataSource = this.unit.Vlasnici.VratiSve();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Uneti podaci nisu validni.");
            }
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            try
            {
                var vlasnik = unit.Vlasnici.VratiPoId(idSelekt);
                unit.Vlasnici.Obrisi(vlasnik);
                unit.Sacuvaj();
                dgvVlasnici.DataSource = unit.Vlasnici.VratiSve();
                MessageBox.Show("Vlasnik obrisan.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Uneti podaci nisu validni.");
            }
        }

        private void dgvVlasnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ind = e.RowIndex;
            idSelekt = int.Parse(dgvVlasnici[0, ind].Value.ToString());
            lblBrisanje.Text = "Vlasnik za brisanje (ID):";
            lblBrisanje.Text = "Vlasnik za brisanje (ID):" + idSelekt.ToString();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVozilaV.DataSource = unit.Vlasnici.MojaPutnicka(idSelekt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uneti podaci nisu validni.");
            }
        }

        private void btnTeretna_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVozilaV.DataSource = unit.Vlasnici.MojaTeretna(idSelekt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uneti podaci nisu validni.");
            }

        }
    }
}
