namespace RegistracijaVozila
{
    partial class OrganizacijaForm
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
            this.dgvOrganizacije = new System.Windows.Forms.DataGridView();
            this.txtNaziv = new MetroFramework.Controls.MetroTextBox();
            this.txtGrad = new MetroFramework.Controls.MetroTextBox();
            this.txtUlica = new MetroFramework.Controls.MetroTextBox();
            this.lbINaziv = new MetroFramework.Controls.MetroLabel();
            this.lblGrad = new MetroFramework.Controls.MetroLabel();
            this.lblUlica = new MetroFramework.Controls.MetroLabel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnRadnici = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.lblBrisanje = new System.Windows.Forms.Label();
            this.dgvRadnici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizacije
            // 
            this.dgvOrganizacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizacije.Location = new System.Drawing.Point(-1, 27);
            this.dgvOrganizacije.Name = "dgvOrganizacije";
            this.dgvOrganizacije.Size = new System.Drawing.Size(401, 219);
            this.dgvOrganizacije.TabIndex = 1;
            this.dgvOrganizacije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrganizacije_CellClick);
            // 
            // txtNaziv
            // 
            // 
            // 
            // 
            this.txtNaziv.CustomButton.Image = null;
            this.txtNaziv.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtNaziv.CustomButton.Name = "";
            this.txtNaziv.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtNaziv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNaziv.CustomButton.TabIndex = 1;
            this.txtNaziv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNaziv.CustomButton.UseSelectable = true;
            this.txtNaziv.CustomButton.Visible = false;
            this.txtNaziv.Lines = new string[0];
            this.txtNaziv.Location = new System.Drawing.Point(57, 269);
            this.txtNaziv.MaxLength = 32767;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.PasswordChar = '\0';
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNaziv.SelectedText = "";
            this.txtNaziv.SelectionLength = 0;
            this.txtNaziv.SelectionStart = 0;
            this.txtNaziv.ShortcutsEnabled = true;
            this.txtNaziv.Size = new System.Drawing.Size(103, 21);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.UseSelectable = true;
            this.txtNaziv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNaziv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGrad
            // 
            // 
            // 
            // 
            this.txtGrad.CustomButton.Image = null;
            this.txtGrad.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtGrad.CustomButton.Name = "";
            this.txtGrad.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtGrad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrad.CustomButton.TabIndex = 1;
            this.txtGrad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrad.CustomButton.UseSelectable = true;
            this.txtGrad.CustomButton.Visible = false;
            this.txtGrad.Lines = new string[0];
            this.txtGrad.Location = new System.Drawing.Point(57, 308);
            this.txtGrad.MaxLength = 32767;
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.PasswordChar = '\0';
            this.txtGrad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrad.SelectedText = "";
            this.txtGrad.SelectionLength = 0;
            this.txtGrad.SelectionStart = 0;
            this.txtGrad.ShortcutsEnabled = true;
            this.txtGrad.Size = new System.Drawing.Size(103, 21);
            this.txtGrad.TabIndex = 3;
            this.txtGrad.UseSelectable = true;
            this.txtGrad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUlica
            // 
            // 
            // 
            // 
            this.txtUlica.CustomButton.Image = null;
            this.txtUlica.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtUlica.CustomButton.Name = "";
            this.txtUlica.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtUlica.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUlica.CustomButton.TabIndex = 1;
            this.txtUlica.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUlica.CustomButton.UseSelectable = true;
            this.txtUlica.CustomButton.Visible = false;
            this.txtUlica.Lines = new string[0];
            this.txtUlica.Location = new System.Drawing.Point(57, 345);
            this.txtUlica.MaxLength = 32767;
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.PasswordChar = '\0';
            this.txtUlica.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUlica.SelectedText = "";
            this.txtUlica.SelectionLength = 0;
            this.txtUlica.SelectionStart = 0;
            this.txtUlica.ShortcutsEnabled = true;
            this.txtUlica.Size = new System.Drawing.Size(103, 21);
            this.txtUlica.TabIndex = 4;
            this.txtUlica.UseSelectable = true;
            this.txtUlica.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUlica.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbINaziv
            // 
            this.lbINaziv.AutoSize = true;
            this.lbINaziv.Location = new System.Drawing.Point(175, 271);
            this.lbINaziv.Name = "lbINaziv";
            this.lbINaziv.Size = new System.Drawing.Size(41, 19);
            this.lbINaziv.TabIndex = 5;
            this.lbINaziv.Text = "Naziv";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(174, 310);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(38, 19);
            this.lblGrad.TabIndex = 6;
            this.lblGrad.Text = "Grad";
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Location = new System.Drawing.Point(174, 345);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(37, 19);
            this.lblUlica.TabIndex = 7;
            this.lblUlica.Text = "Ulica";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(303, 297);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 32);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnRadnici
            // 
            this.btnRadnici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRadnici.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRadnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadnici.Location = new System.Drawing.Point(427, 297);
            this.btnRadnici.Name = "btnRadnici";
            this.btnRadnici.Size = new System.Drawing.Size(88, 41);
            this.btnRadnici.TabIndex = 12;
            this.btnRadnici.Text = "Prikazi radnike";
            this.btnRadnici.UseVisualStyleBackColor = false;
            this.btnRadnici.Click += new System.EventHandler(this.btnRadnici_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanje.Location = new System.Drawing.Point(551, 297);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(88, 32);
            this.btnBrisanje.TabIndex = 13;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // lblBrisanje
            // 
            this.lblBrisanje.AutoSize = true;
            this.lblBrisanje.Location = new System.Drawing.Point(530, 258);
            this.lblBrisanje.Name = "lblBrisanje";
            this.lblBrisanje.Size = new System.Drawing.Size(144, 13);
            this.lblBrisanje.TabIndex = 26;
            this.lblBrisanje.Text = "Organizacija za brisanje (ID): ";
            // 
            // dgvRadnici
            // 
            this.dgvRadnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnici.Location = new System.Drawing.Point(406, 27);
            this.dgvRadnici.Name = "dgvRadnici";
            this.dgvRadnici.Size = new System.Drawing.Size(401, 219);
            this.dgvRadnici.TabIndex = 27;
            this.dgvRadnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRadnici_CellContentClick);
            // 
            // OrganizacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.dgvRadnici);
            this.Controls.Add(this.lblBrisanje);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnRadnici);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblUlica);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.lbINaziv);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgvOrganizacije);
            this.MaximumSize = new System.Drawing.Size(810, 450);
            this.MinimumSize = new System.Drawing.Size(810, 450);
            this.Name = "OrganizacijaForm";
            this.Text = "OrganizacijaForm";
            this.Load += new System.EventHandler(this.OrganizacijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganizacije;
        private MetroFramework.Controls.MetroTextBox txtNaziv;
        private MetroFramework.Controls.MetroTextBox txtGrad;
        private MetroFramework.Controls.MetroTextBox txtUlica;
        private MetroFramework.Controls.MetroLabel lbINaziv;
        private MetroFramework.Controls.MetroLabel lblGrad;
        private MetroFramework.Controls.MetroLabel lblUlica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnRadnici;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Label lblBrisanje;
        private System.Windows.Forms.DataGridView dgvRadnici;
    }
}