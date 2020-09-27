namespace RegistracijaVozila
{
    partial class VlasnikForm
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
            this.dgvVlasnici = new System.Windows.Forms.DataGridView();
            this.txtIme = new MetroFramework.Controls.MetroTextBox();
            this.txtPrezime = new MetroFramework.Controls.MetroTextBox();
            this.lbIme = new MetroFramework.Controls.MetroLabel();
            this.lblPrezime = new MetroFramework.Controls.MetroLabel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.lblBrisanje = new System.Windows.Forms.Label();
            this.dgvVozilaV = new System.Windows.Forms.DataGridView();
            this.btnTeretna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVlasnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilaV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVlasnici
            // 
            this.dgvVlasnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVlasnici.Location = new System.Drawing.Point(0, 28);
            this.dgvVlasnici.Name = "dgvVlasnici";
            this.dgvVlasnici.Size = new System.Drawing.Size(478, 215);
            this.dgvVlasnici.TabIndex = 3;
            this.dgvVlasnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVlasnici_CellClick);
            // 
            // txtIme
            // 
            // 
            // 
            // 
            this.txtIme.CustomButton.Image = null;
            this.txtIme.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtIme.CustomButton.Name = "";
            this.txtIme.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtIme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIme.CustomButton.TabIndex = 1;
            this.txtIme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIme.CustomButton.UseSelectable = true;
            this.txtIme.CustomButton.Visible = false;
            this.txtIme.Lines = new string[0];
            this.txtIme.Location = new System.Drawing.Point(68, 275);
            this.txtIme.MaxLength = 32767;
            this.txtIme.Name = "txtIme";
            this.txtIme.PasswordChar = '\0';
            this.txtIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIme.SelectedText = "";
            this.txtIme.SelectionLength = 0;
            this.txtIme.SelectionStart = 0;
            this.txtIme.ShortcutsEnabled = true;
            this.txtIme.Size = new System.Drawing.Size(118, 21);
            this.txtIme.TabIndex = 4;
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
            this.txtPrezime.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtPrezime.CustomButton.Name = "";
            this.txtPrezime.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtPrezime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrezime.CustomButton.TabIndex = 1;
            this.txtPrezime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrezime.CustomButton.UseSelectable = true;
            this.txtPrezime.CustomButton.Visible = false;
            this.txtPrezime.Lines = new string[0];
            this.txtPrezime.Location = new System.Drawing.Point(68, 324);
            this.txtPrezime.MaxLength = 32767;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.PasswordChar = '\0';
            this.txtPrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrezime.SelectedText = "";
            this.txtPrezime.SelectionLength = 0;
            this.txtPrezime.SelectionStart = 0;
            this.txtPrezime.ShortcutsEnabled = true;
            this.txtPrezime.Size = new System.Drawing.Size(118, 21);
            this.txtPrezime.TabIndex = 5;
            this.txtPrezime.UseSelectable = true;
            this.txtPrezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(204, 275);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(31, 19);
            this.lbIme.TabIndex = 14;
            this.lbIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(204, 324);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(57, 19);
            this.lblPrezime.TabIndex = 15;
            this.lblPrezime.Text = "Prezime";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(333, 302);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 32);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVozila.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozila.Location = new System.Drawing.Point(462, 302);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(88, 43);
            this.btnVozila.TabIndex = 18;
            this.btnVozila.Text = "Prikazi putnicka";
            this.btnVozila.UseVisualStyleBackColor = false;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanje.Location = new System.Drawing.Point(591, 302);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(88, 32);
            this.btnBrisanje.TabIndex = 19;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // lblBrisanje
            // 
            this.lblBrisanje.AutoSize = true;
            this.lblBrisanje.Location = new System.Drawing.Point(575, 266);
            this.lblBrisanje.Name = "lblBrisanje";
            this.lblBrisanje.Size = new System.Drawing.Size(120, 13);
            this.lblBrisanje.TabIndex = 26;
            this.lblBrisanje.Text = "Vlasnik za brisanje (ID): ";
            this.lblBrisanje.Click += new System.EventHandler(this.lblBrisanje_Click);
            // 
            // dgvVozilaV
            // 
            this.dgvVozilaV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozilaV.Location = new System.Drawing.Point(484, 28);
            this.dgvVozilaV.Name = "dgvVozilaV";
            this.dgvVozilaV.Size = new System.Drawing.Size(412, 215);
            this.dgvVozilaV.TabIndex = 27;
            // 
            // btnTeretna
            // 
            this.btnTeretna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeretna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeretna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeretna.Location = new System.Drawing.Point(462, 362);
            this.btnTeretna.Name = "btnTeretna";
            this.btnTeretna.Size = new System.Drawing.Size(88, 43);
            this.btnTeretna.TabIndex = 28;
            this.btnTeretna.Text = "Prikazi teretna";
            this.btnTeretna.UseVisualStyleBackColor = false;
            this.btnTeretna.Click += new System.EventHandler(this.btnTeretna_Click);
            // 
            // VlasnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.btnTeretna);
            this.Controls.Add(this.dgvVozilaV);
            this.Controls.Add(this.lblBrisanje);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.dgvVlasnici);
            this.MaximumSize = new System.Drawing.Size(895, 450);
            this.MinimumSize = new System.Drawing.Size(895, 450);
            this.Name = "VlasnikForm";
            this.Text = "VlasnikForm";
            this.Load += new System.EventHandler(this.VlasnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVlasnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilaV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVlasnici;
        private MetroFramework.Controls.MetroTextBox txtIme;
        private MetroFramework.Controls.MetroTextBox txtPrezime;
        private MetroFramework.Controls.MetroLabel lbIme;
        private MetroFramework.Controls.MetroLabel lblPrezime;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Label lblBrisanje;
        private System.Windows.Forms.DataGridView dgvVozilaV;
        private System.Windows.Forms.Button btnTeretna;
    }
}