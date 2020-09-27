using RegistracijaVozila.Baza;
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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();

    }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbVozilo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVlasnik.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRad.SizeMode = PictureBoxSizeMode.StretchImage;
            pbReg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVozilo.BackColor = Color.Transparent;
            pbVlasnik.BackColor = Color.Transparent;
            pbOrg.BackColor = Color.Transparent;
            pbRad.BackColor = Color.Transparent;
            pbReg.BackColor = Color.Transparent;
            mlbOrg.BackColor = Color.Transparent;
            mlbReg.BackColor = Color.Transparent;
            mlbRad.BackColor = Color.Transparent;
            mlbVoz.BackColor = Color.Transparent;
            mlbVlas.BackColor = Color.Transparent;

        }

        private void pbVozilo_Click(object sender, EventArgs e)
        {
            VozilaForm vozila = new VozilaForm();
            vozila.Show();
        }
        

        private void pbRad_Click_1(object sender, EventArgs e)
        {
            RadnikForm radnik = new RadnikForm();
            radnik.Show();
        }

        private void pbOrg_Click_1(object sender, EventArgs e)
        {
            OrganizacijaForm organizacija = new OrganizacijaForm();
            organizacija.Show();
        }

        private void pbVlasnik_Click_1(object sender, EventArgs e)
        {
            VlasnikForm vlasnik = new VlasnikForm();
            vlasnik.Show();
        }

        private void pbReg_Click(object sender, EventArgs e)
        {
            RegistracijaForm registracija = new RegistracijaForm();
            registracija.Show();
        }
    }
}