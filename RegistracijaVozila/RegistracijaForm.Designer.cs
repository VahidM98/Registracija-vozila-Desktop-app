namespace RegistracijaVozila
{
    partial class RegistracijaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRegistracije = new System.Windows.Forms.DataGridView();
            this.txtCena = new MetroFramework.Controls.MetroTextBox();
            this.lbICena = new MetroFramework.Controls.MetroLabel();
            this.dtpDatum = new MetroFramework.Controls.MetroDateTime();
            this.lblDatum = new MetroFramework.Controls.MetroLabel();
            this.cmbVozila = new System.Windows.Forms.ComboBox();
            this.cmbRadnici = new System.Windows.Forms.ComboBox();
            this.lblVozilo = new MetroFramework.Controls.MetroLabel();
            this.lblRadnik = new MetroFramework.Controls.MetroLabel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblVlasnik = new System.Windows.Forms.Label();
            this.btnP = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.lblVoz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistracije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistracije
            // 
            this.dgvRegistracije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistracije.Location = new System.Drawing.Point(0, 27);
            this.dgvRegistracije.Name = "dgvRegistracije";
            this.dgvRegistracije.Size = new System.Drawing.Size(801, 216);
            this.dgvRegistracije.TabIndex = 2;
            this.dgvRegistracije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistracije_CellClick);
            // 
            // txtCena
            // 
            // 
            // 
            // 
            this.txtCena.CustomButton.Image = null;
            this.txtCena.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtCena.CustomButton.Name = "";
            this.txtCena.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtCena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCena.CustomButton.TabIndex = 1;
            this.txtCena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCena.CustomButton.UseSelectable = true;
            this.txtCena.CustomButton.Visible = false;
            this.txtCena.Lines = new string[0];
            this.txtCena.Location = new System.Drawing.Point(47, 344);
            this.txtCena.MaxLength = 32767;
            this.txtCena.Name = "txtCena";
            this.txtCena.PasswordChar = '\0';
            this.txtCena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCena.SelectedText = "";
            this.txtCena.SelectionLength = 0;
            this.txtCena.SelectionStart = 0;
            this.txtCena.ShortcutsEnabled = true;
            this.txtCena.Size = new System.Drawing.Size(118, 21);
            this.txtCena.TabIndex = 3;
            this.txtCena.UseSelectable = true;
            this.txtCena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbICena
            // 
            this.lbICena.AutoSize = true;
            this.lbICena.Location = new System.Drawing.Point(183, 346);
            this.lbICena.Name = "lbICena";
            this.lbICena.Size = new System.Drawing.Size(39, 19);
            this.lbICena.TabIndex = 6;
            this.lbICena.Text = "Cena";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(47, 381);
            this.dtpDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(219, 29);
            this.dtpDatum.TabIndex = 7;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(283, 391);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(48, 19);
            this.lblDatum.TabIndex = 8;
            this.lblDatum.Text = "Datum";
            // 
            // cmbVozila
            // 
            this.cmbVozila.FormattingEnabled = true;
            this.cmbVozila.Location = new System.Drawing.Point(47, 302);
            this.cmbVozila.Name = "cmbVozila";
            this.cmbVozila.Size = new System.Drawing.Size(118, 21);
            this.cmbVozila.TabIndex = 10;
            // 
            // cmbRadnici
            // 
            this.cmbRadnici.FormattingEnabled = true;
            this.cmbRadnici.Location = new System.Drawing.Point(47, 264);
            this.cmbRadnici.Name = "cmbRadnici";
            this.cmbRadnici.Size = new System.Drawing.Size(118, 21);
            this.cmbRadnici.TabIndex = 11;
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Location = new System.Drawing.Point(183, 304);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(44, 19);
            this.lblVozilo.TabIndex = 12;
            this.lblVozilo.Text = "Vozilo";
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Location = new System.Drawing.Point(183, 266);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(48, 19);
            this.lblRadnik.TabIndex = 13;
            this.lblRadnik.Text = "Radnik";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(383, 295);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 32);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblVlasnik
            // 
            this.lblVlasnik.AutoSize = true;
            this.lblVlasnik.Location = new System.Drawing.Point(506, 295);
            this.lblVlasnik.Name = "lblVlasnik";
            this.lblVlasnik.Size = new System.Drawing.Size(155, 13);
            this.lblVlasnik.TabIndex = 26;
            this.lblVlasnik.Text = "Vlasnik odabranog automobila: ";
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(245, 300);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(32, 23);
            this.btnP.TabIndex = 27;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(299, 300);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(32, 23);
            this.btnV.TabIndex = 28;
            this.btnV.Text = "T";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // lblVoz
            // 
            this.lblVoz.AutoSize = true;
            this.lblVoz.Location = new System.Drawing.Point(506, 331);
            this.lblVoz.Name = "lblVoz";
            this.lblVoz.Size = new System.Drawing.Size(117, 13);
            this.lblVoz.TabIndex = 29;
            this.lblVoz.Text = "Selektovani automobil: ";
            // 
            // RegistracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVoz);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.lblVlasnik);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblRadnik);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.cmbRadnici);
            this.Controls.Add(this.cmbVozila);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lbICena);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.dgvRegistracije);
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "RegistracijaForm";
            this.Text = "RegistracijaForm";
            this.Load += new System.EventHandler(this.RegistracijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistracije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistracije;
        private MetroFramework.Controls.MetroTextBox txtCena;
        private MetroFramework.Controls.MetroLabel lbICena;
        private MetroFramework.Controls.MetroDateTime dtpDatum;
        private MetroFramework.Controls.MetroLabel lblDatum;
        private System.Windows.Forms.ComboBox cmbVozila;
        private System.Windows.Forms.ComboBox cmbRadnici;
        private MetroFramework.Controls.MetroLabel lblVozilo;
        private MetroFramework.Controls.MetroLabel lblRadnik;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblVlasnik;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Label lblVoz;
    }
}