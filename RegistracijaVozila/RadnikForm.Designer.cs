namespace RegistracijaVozila
{
    partial class RadnikForm
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
            this.dgvRadnici = new System.Windows.Forms.DataGridView();
            this.txtIme = new MetroFramework.Controls.MetroTextBox();
            this.txtPrezime = new MetroFramework.Controls.MetroTextBox();
            this.lbIme = new MetroFramework.Controls.MetroLabel();
            this.lbPrezime = new MetroFramework.Controls.MetroLabel();
            this.lbGod = new MetroFramework.Controls.MetroLabel();
            this.lbOrganizacija = new MetroFramework.Controls.MetroLabel();
            this.txtGod = new MetroFramework.Controls.MetroTextBox();
            this.cmbOrganizacija = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.lblBrisanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRadnici
            // 
            this.dgvRadnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnici.Location = new System.Drawing.Point(0, 27);
            this.dgvRadnici.Name = "dgvRadnici";
            this.dgvRadnici.Size = new System.Drawing.Size(799, 207);
            this.dgvRadnici.TabIndex = 0;
            this.dgvRadnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRadnici_CellClick);
            this.dgvRadnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRadnici_CellContentClick);
            // 
            // txtIme
            // 
            // 
            // 
            // 
            this.txtIme.CustomButton.Image = null;
            this.txtIme.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtIme.CustomButton.Name = "";
            this.txtIme.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtIme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIme.CustomButton.TabIndex = 1;
            this.txtIme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIme.CustomButton.UseSelectable = true;
            this.txtIme.CustomButton.Visible = false;
            this.txtIme.Lines = new string[0];
            this.txtIme.Location = new System.Drawing.Point(45, 254);
            this.txtIme.MaxLength = 32767;
            this.txtIme.Name = "txtIme";
            this.txtIme.PasswordChar = '\0';
            this.txtIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIme.SelectedText = "";
            this.txtIme.SelectionLength = 0;
            this.txtIme.SelectionStart = 0;
            this.txtIme.ShortcutsEnabled = true;
            this.txtIme.Size = new System.Drawing.Size(103, 21);
            this.txtIme.TabIndex = 1;
            this.txtIme.UseSelectable = true;
            this.txtIme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrezime
            // 
            // 
            // 
            // 
            this.txtPrezime.CustomButton.Image = null;
            this.txtPrezime.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtPrezime.CustomButton.Name = "";
            this.txtPrezime.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtPrezime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrezime.CustomButton.TabIndex = 1;
            this.txtPrezime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrezime.CustomButton.UseSelectable = true;
            this.txtPrezime.CustomButton.Visible = false;
            this.txtPrezime.Lines = new string[0];
            this.txtPrezime.Location = new System.Drawing.Point(45, 288);
            this.txtPrezime.MaxLength = 32767;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.PasswordChar = '\0';
            this.txtPrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrezime.SelectedText = "";
            this.txtPrezime.SelectionLength = 0;
            this.txtPrezime.SelectionStart = 0;
            this.txtPrezime.ShortcutsEnabled = true;
            this.txtPrezime.Size = new System.Drawing.Size(103, 21);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.UseSelectable = true;
            this.txtPrezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(167, 256);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(31, 19);
            this.lbIme.TabIndex = 3;
            this.lbIme.Text = "Ime";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(167, 290);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(57, 19);
            this.lbPrezime.TabIndex = 4;
            this.lbPrezime.Text = "Prezime";
            // 
            // lbGod
            // 
            this.lbGod.AutoSize = true;
            this.lbGod.Location = new System.Drawing.Point(167, 327);
            this.lbGod.Name = "lbGod";
            this.lbGod.Size = new System.Drawing.Size(51, 19);
            this.lbGod.TabIndex = 5;
            this.lbGod.Text = "Godine";
            // 
            // lbOrganizacija
            // 
            this.lbOrganizacija.AutoSize = true;
            this.lbOrganizacija.Location = new System.Drawing.Point(167, 363);
            this.lbOrganizacija.Name = "lbOrganizacija";
            this.lbOrganizacija.Size = new System.Drawing.Size(82, 19);
            this.lbOrganizacija.TabIndex = 6;
            this.lbOrganizacija.Text = "Organizacija";
            this.lbOrganizacija.Click += new System.EventHandler(this.lbOrganizacija_Click);
            // 
            // txtGod
            // 
            // 
            // 
            // 
            this.txtGod.CustomButton.Image = null;
            this.txtGod.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtGod.CustomButton.Name = "";
            this.txtGod.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtGod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGod.CustomButton.TabIndex = 1;
            this.txtGod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGod.CustomButton.UseSelectable = true;
            this.txtGod.CustomButton.Visible = false;
            this.txtGod.Lines = new string[0];
            this.txtGod.Location = new System.Drawing.Point(45, 325);
            this.txtGod.MaxLength = 32767;
            this.txtGod.Name = "txtGod";
            this.txtGod.PasswordChar = '\0';
            this.txtGod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGod.SelectedText = "";
            this.txtGod.SelectionLength = 0;
            this.txtGod.SelectionStart = 0;
            this.txtGod.ShortcutsEnabled = true;
            this.txtGod.Size = new System.Drawing.Size(103, 21);
            this.txtGod.TabIndex = 7;
            this.txtGod.UseSelectable = true;
            this.txtGod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbOrganizacija
            // 
            this.cmbOrganizacija.FormattingEnabled = true;
            this.cmbOrganizacija.Location = new System.Drawing.Point(45, 361);
            this.cmbOrganizacija.Name = "cmbOrganizacija";
            this.cmbOrganizacija.Size = new System.Drawing.Size(103, 21);
            this.cmbOrganizacija.TabIndex = 8;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(291, 288);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 32);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(419, 288);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(88, 32);
            this.btnIzmeni.TabIndex = 10;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanje.Location = new System.Drawing.Point(538, 288);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(88, 32);
            this.btnBrisanje.TabIndex = 11;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // lblBrisanje
            // 
            this.lblBrisanje.AutoSize = true;
            this.lblBrisanje.Location = new System.Drawing.Point(525, 254);
            this.lblBrisanje.Name = "lblBrisanje";
            this.lblBrisanje.Size = new System.Drawing.Size(120, 13);
            this.lblBrisanje.TabIndex = 26;
            this.lblBrisanje.Text = "Radnik za brisanje (ID): ";
            // 
            // RadnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.lblBrisanje);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbOrganizacija);
            this.Controls.Add(this.txtGod);
            this.Controls.Add(this.lbOrganizacija);
            this.Controls.Add(this.lbGod);
            this.Controls.Add(this.lbPrezime);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.dgvRadnici);
            this.MaximumSize = new System.Drawing.Size(799, 450);
            this.MinimumSize = new System.Drawing.Size(799, 450);
            this.Name = "RadnikForm";
            this.Text = "RadnikForm";
            this.Load += new System.EventHandler(this.RadnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRadnici;
        private MetroFramework.Controls.MetroTextBox txtIme;
        private MetroFramework.Controls.MetroTextBox txtPrezime;
        private MetroFramework.Controls.MetroLabel lbIme;
        private MetroFramework.Controls.MetroLabel lbPrezime;
        private MetroFramework.Controls.MetroLabel lbGod;
        private MetroFramework.Controls.MetroLabel lbOrganizacija;
        private MetroFramework.Controls.MetroTextBox txtGod;
        private System.Windows.Forms.ComboBox cmbOrganizacija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Label lblBrisanje;
    }
}