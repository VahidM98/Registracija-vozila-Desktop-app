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
    public partial class RadnikForm : MetroFramework.Forms.MetroForm
    {
        private UnitOfWork unit;
        private int idSelekt;
        private List<string> orgs = new List<string>();
        public RadnikForm()
        {
            InitializeComponent();
            var context = new VoziloContext();
            unit = new UnitOfWork(context);
            dgvRadnici.DataSource = unit.Radnici.VratiSve();
            var sveOrg = unit.Organizacije.VratiSve();
            foreach(var org in sveOrg)
            {
                orgs.Add(org.ToString());
            }
            cmbOrganizacija.DataSource = orgs;
        }

        private void RadnikForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbOrganizacija_Click(object sender, EventArgs e)
        {

        }

        private void dgvRadnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                var novi = new Radnik();
                novi.Ime = txtIme.Text;
                novi.Prezime = txtPrezime.Text;
                novi.Godine = int.Parse(txtGod.Text);
                novi.OrganizacijaId = int.Parse(cmbOrganizacija.Text.Split(' ')[0]);
                unit.Radnici.Dodaj(novi);
                unit.Sacuvaj();
                MessageBox.Show("Radnik dodat.");
                dgvRadnici.DataSource = unit.Radnici.VratiSve();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Uneti podaci nisu validni.");
            }
        }

        private void dgvRadnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var ind = e.RowIndex;
                idSelekt = int.Parse(dgvRadnici[0, ind].Value.ToString());
                lblBrisanje.Text = "Radnik za brisanje (ID):";
                lblBrisanje.Text = "Radnik za brisanje (ID):" + idSelekt.ToString();

                var odabran = unit.Radnici.VratiPoId(idSelekt);
                txtIme.Text = odabran.Ime;
                txtPrezime.Text = odabran.Prezime;
                txtGod.Text = odabran.Godine.ToString();
                cmbOrganizacija.Text = odabran.OrganizacijaId.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greska.");
            }

        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            try
            {
                var radnik = unit.Radnici.VratiPoId(idSelekt);
                unit.Radnici.Obrisi(radnik);
                unit.Sacuvaj();
                dgvRadnici.DataSource = unit.Radnici.VratiSve();
                MessageBox.Show("Radnik obrisan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Radnik obrisan.");
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                var radnik = unit.Radnici.VratiPoId(idSelekt);
                radnik.Ime = txtIme.Text;
                radnik.Prezime = txtPrezime.Text;
                radnik.Godine = int.Parse(txtGod.Text);
                radnik.OrganizacijaId = int.Parse(cmbOrganizacija.Text.Split(' ')[0]);
                unit.Sacuvaj();
                dgvRadnici.Refresh();
               // dgvRadnici.DataSource = unit.Radnici.VratiSve();
                MessageBox.Show("Radnik izmenjen.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Radnik obrisan.");
            }
        }
    }
}
