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
    public partial class OrganizacijaForm : MetroFramework.Forms.MetroForm
    {
        private UnitOfWork unit;
        private int idSelekt;
        public OrganizacijaForm()
        {
            InitializeComponent();
            var context = new VoziloContext();
            unit = new UnitOfWork(context);
            dgvOrganizacije.DataSource = unit.Organizacije.VratiSve();
        }

        private void OrganizacijaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                var naziv = txtNaziv.Text;
                var grad = txtGrad.Text;
                var ulica = txtUlica.Text;

                var nova = new Organizacija();
                nova.Naziv = naziv;
                nova.Grad = grad;
                nova.Ulica = ulica;

                unit.Organizacije.Dodaj(nova);
                unit.Sacuvaj();
                MessageBox.Show("Organizacija dodata.");
                dgvOrganizacije.DataSource = this.unit.Organizacije.VratiSve();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Uneti podaci nisu validni.");
            }




        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            try
            {
                var organizacija = unit.Organizacije.VratiPoId(idSelekt);
                unit.Organizacije.Obrisi(organizacija);
                unit.Sacuvaj();
                dgvOrganizacije.DataSource = unit.Organizacije.VratiSve();
                MessageBox.Show("Organizacija obrisana.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uneti podaci nisu validni.");
            }
        }

        private void dgvOrganizacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var ind = e.RowIndex;
            idSelekt = int.Parse(dgvOrganizacije[0, ind].Value.ToString());
            lblBrisanje.Text = "Organizacija za brisanje (ID):";
            lblBrisanje.Text = "Organizacija za brisanje (ID):" + idSelekt.ToString();
        }

        private void btnRadnici_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRadnici.DataSource = unit.Organizacije.radniciOrg(idSelekt);

            } catch(Exception ex)
            {
                MessageBox.Show("Doslo je do greske.");
            }
        }

        private void dgvRadnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
