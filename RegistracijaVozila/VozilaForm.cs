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
    public partial class VozilaForm : MetroFramework.Forms.MetroForm
    {
        private UnitOfWork unit;
        private List<string> boje;
        private List<Putnicko> putnickaSva;
        private List<Teretno> teretnaSva;
        private bool putnickoIliNe = true;
        private int idIzmena = 0;
        public VozilaForm()
        {
            InitializeComponent();
            var context = new VoziloContext();
            unit = new UnitOfWork(context);
            putnickaSva = unit.Vozila.VratiSva().ToList();
             teretnaSva = unit.Teretna.VratiSva().ToList();
            dgvVozila.DataSource = putnickaSva;
            // dgvVozila.DataSource = context.Vozila.ToList();
            boje = new List<string>();
            boje.Add("Crna");
            boje.Add("Siva");
            boje.Add("Bela");
            boje.Add("Crvena");
            boje.Add("Zuta");
            boje.Add("Plava");
            boje.Add("Zelena");
            cmbBoja.DataSource = boje;
            var tipovi = new List<string>();
            tipovi.Add("Putnicko");
            tipovi.Add("Teretno");
            cmbTip.DataSource = tipovi;

            var vlasnici = unit.Vlasnici.VratiSve();
            List<string> vlasniciBiraj = new List<string>();
            foreach (var v in vlasnici)
            {
                vlasniciBiraj.Add(v.ToString());
            }
            cmbVlasnik.DataSource = vlasniciBiraj;

        }

        private void dgvVozila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var proizvodjac = txtPro.Text;
                var tip = cmbTip.Text;
                var godina = int.Parse(txtGodina.Text);
                var boja = cmbBoja.Text;
                var razdvoj = cmbVlasnik.Text.Split(' ');
                var vlasnik = unit.Vlasnici.VratiPoId(int.Parse(razdvoj[0]));
                var snaga = txtSnaga.Text != ""?  float.Parse(txtSnaga.Text) : 100;
                var nosivost = txtTeret.Text != "" ? float.Parse(txtTeret.Text) : 100;

                if(tip=="Putnicko")
                {
                    var novo = new Putnicko();
                    novo.Boja = boja;
                    novo.Proizvodjac = proizvodjac;
                    novo.Vlasnik = vlasnik;
                    novo.Snaga = snaga;
                    novo.GodProizvodnje = godina;
                    novo.Tip = tip;

                    unit.Vozila.Dodaj(novo);
                    unit.Sacuvaj();
                    dgvVozila.DataSource = unit.Vozila.VratiSva();
                } else
                {
                    var novo = new Teretno();
                    novo.Boja = boja;
                    novo.Proizvodjac = proizvodjac;
                    novo.Vlasnik = vlasnik;
                    novo.Nosivost = nosivost;
                    novo.GodProizvodnje = godina;
                    novo.Tip = tip;
                    unit.Teretna.Dodaj(novo);
                    unit.Sacuvaj();
                    dgvVozila.DataSource = unit.Teretna.VratiSva();
                }
                
                

                MessageBox.Show("Dodat auto");

            } catch(Exception ex)
            {
                MessageBox.Show("Uneti podaci nisu ispravni.");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            dgvVozila.DataSource = putnickaSva;
            putnickoIliNe = true;
            dgvVozila.Refresh();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            dgvVozila.DataSource = teretnaSva;
            putnickoIliNe = false;
            dgvVozila.Refresh();
        }

        private void dgvVozila_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Putnicko vozilo = null;
                Teretno vozilo2 = null;
                var ind = e.RowIndex;
                idIzmena = int.Parse(dgvVozila[0, ind].Value.ToString());
                if(putnickoIliNe)
                {
                    vozilo = unit.Vozila.VratiPoId(idIzmena);
                    txtGodina.Text = vozilo.GodProizvodnje.ToString();
                    txtPro.Text = vozilo.Proizvodjac.ToString();
                    txtSnaga.Text = vozilo.Snaga.ToString();
                    cmbBoja.Text = vozilo.Boja.ToString();
                    cmbVlasnik.Text = vozilo.VlasnikId.ToString();
                    lblBrisanje.Text = "Vozilo za brisanje (ID):";
                    lblBrisanje.Text = lblBrisanje.Text + "Putnicko " + vozilo.PutnickoId.ToString();
                } else
                {
                    vozilo2 = unit.Teretna.VratiPoId(idIzmena);
                    txtGodina.Text = vozilo2.GodProizvodnje.ToString();
                    txtPro.Text = vozilo2.Proizvodjac.ToString();
                    txtTeret.Text = vozilo2.Nosivost.ToString();
                    cmbBoja.Text = vozilo2.Boja.ToString();
                    cmbVlasnik.Text = vozilo2.VlasnikId.ToString();
                    lblBrisanje.Text = "Vozilo za brisanje (ID):";
                    lblBrisanje.Text = lblBrisanje.Text + "Teretno " + vozilo2.TeretnoId.ToString();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                Putnicko vozilo = null;
                Teretno vozilo2 = null;
                if (putnickoIliNe)
                {
                    vozilo = unit.Vozila.VratiPoId(idIzmena);
                    var proizvodjac = txtPro.Text;
                    var godina = int.Parse(txtGodina.Text);
                    var boja = cmbBoja.Text;
                    var razdvoj = cmbVlasnik.Text.Split(' ');
                    var vlasnik = unit.Vlasnici.VratiPoId(int.Parse(razdvoj[0]));
                    var snaga = txtSnaga.Text != "" ? float.Parse(txtSnaga.Text) : 100;

                    vozilo.Proizvodjac = proizvodjac;
                    vozilo.GodProizvodnje = godina;
                    vozilo.Boja = boja;
                    vozilo.Vlasnik = vlasnik;
                    vozilo.Snaga = snaga;

                    unit.Sacuvaj();
                    dgvVozila.Refresh();
                    MessageBox.Show("Izmene uspesne.");

                }
                else
                {
                    vozilo2 = unit.Teretna.VratiPoId(idIzmena);
                    var proizvodjac = txtPro.Text;
                    var godina = int.Parse(txtGodina.Text);
                    var boja = cmbBoja.Text;
                    var razdvoj = cmbVlasnik.Text.Split(' ');
                    var vlasnik = unit.Vlasnici.VratiPoId(int.Parse(razdvoj[0]));
                    var teret = txtTeret.Text != "" ? float.Parse(txtTeret.Text) : 100;

                    vozilo2.Proizvodjac = proizvodjac;
                    vozilo2.GodProizvodnje = godina;
                    vozilo2.Boja = boja;
                    vozilo2.Vlasnik = vlasnik;
                    vozilo2.Nosivost = teret;

                    unit.Sacuvaj();
                    dgvVozila.Refresh();
                    MessageBox.Show("Izmene uspesne.");

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            try
            {
                if(putnickoIliNe)
                {
                    var vozilo = unit.Vozila.VratiPoId(idIzmena);
                    unit.Vozila.Obrisi(vozilo);
                    unit.Sacuvaj();
                    dgvVozila.DataSource = unit.Vozila.VratiSva();
                    lblBrisanje.Text = "Vozilo za brisanje (ID):";
                    MessageBox.Show("Vozilo obrisano.");
              

                } else
                {
                    var vozilo2 = unit.Teretna.VratiPoId(idIzmena);
                    unit.Teretna.Obrisi(vozilo2);
                    unit.Sacuvaj();
                    dgvVozila.DataSource = unit.Teretna.VratiSva();
                    lblBrisanje.Text = "Vozilo za brisanje (ID):";
                    MessageBox.Show("Vozilo obrisano.");
                }
            

            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void VozilaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
