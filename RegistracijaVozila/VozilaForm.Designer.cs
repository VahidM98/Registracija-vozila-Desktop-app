namespace RegistracijaVozila
{
    partial class VozilaForm
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
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.txtPro = new MetroFramework.Controls.MetroTextBox();
            this.txtGodina = new MetroFramework.Controls.MetroTextBox();
            this.txtSnaga = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtTeret = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblGodina = new MetroFramework.Controls.MetroLabel();
            this.lblBoja = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbBoja = new System.Windows.Forms.ComboBox();
            this.cmbVlasnik = new System.Windows.Forms.ComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.lblBrisanje = new System.Windows.Forms.Label();
            this.btnBrisanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozila
            // 
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Location = new System.Drawing.Point(0, 25);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.Size = new System.Drawing.Size(801, 276);
            this.dgvVozila.TabIndex = 0;
            this.dgvVozila.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVozila_CellClick);
            this.dgvVozila.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVozila_CellContentClick);
            // 
            // txtPro
            // 
            // 
            // 
            // 
            this.txtPro.CustomButton.Image = null;
            this.txtPro.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtPro.CustomButton.Name = "";
            this.txtPro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPro.CustomButton.TabIndex = 1;
            this.txtPro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPro.CustomButton.UseSelectable = true;
            this.txtPro.CustomButton.Visible = false;
            this.txtPro.Lines = new string[0];
            this.txtPro.Location = new System.Drawing.Point(23, 323);
            this.txtPro.MaxLength = 32767;
            this.txtPro.Name = "txtPro";
            this.txtPro.PasswordChar = '\0';
            this.txtPro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPro.SelectedText = "";
            this.txtPro.SelectionLength = 0;
            this.txtPro.SelectionStart = 0;
            this.txtPro.ShortcutsEnabled = true;
            this.txtPro.Size = new System.Drawing.Size(117, 23);
            this.txtPro.TabIndex = 1;
            this.txtPro.UseSelectable = true;
            this.txtPro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGodina
            // 
            // 
            // 
            // 
            this.txtGodina.CustomButton.Image = null;
            this.txtGodina.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtGodina.CustomButton.Name = "";
            this.txtGodina.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGodina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGodina.CustomButton.TabIndex = 1;
            this.txtGodina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGodina.CustomButton.UseSelectable = true;
            this.txtGodina.CustomButton.Visible = false;
            this.txtGodina.Lines = new string[0];
            this.txtGodina.Location = new System.Drawing.Point(24, 404);
            this.txtGodina.MaxLength = 32767;
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.PasswordChar = '\0';
            this.txtGodina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGodina.SelectedText = "";
            this.txtGodina.SelectionLength = 0;
            this.txtGodina.SelectionStart = 0;
            this.txtGodina.ShortcutsEnabled = true;
            this.txtGodina.Size = new System.Drawing.Size(116, 23);
            this.txtGodina.TabIndex = 3;
            this.txtGodina.UseSelectable = true;
            this.txtGodina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGodina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGodina.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // txtSnaga
            // 
            // 
            // 
            // 
            this.txtSnaga.CustomButton.Image = null;
            this.txtSnaga.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtSnaga.CustomButton.Name = "";
            this.txtSnaga.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSnaga.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSnaga.CustomButton.TabIndex = 1;
            this.txtSnaga.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSnaga.CustomButton.UseSelectable = true;
            this.txtSnaga.CustomButton.Visible = false;
            this.txtSnaga.Lines = new string[0];
            this.txtSnaga.Location = new System.Drawing.Point(319, 362);
            this.txtSnaga.MaxLength = 32767;
            this.txtSnaga.Name = "txtSnaga";
            this.txtSnaga.PasswordChar = '\0';
            this.txtSnaga.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSnaga.SelectedText = "";
            this.txtSnaga.SelectionLength = 0;
            this.txtSnaga.SelectionStart = 0;
            this.txtSnaga.ShortcutsEnabled = true;
            this.txtSnaga.Size = new System.Drawing.Size(113, 23);
            this.txtSnaga.TabIndex = 6;
            this.txtSnaga.UseSelectable = true;
            this.txtSnaga.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSnaga.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton1.Location = new System.Drawing.Point(319, 445);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(113, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Dodaj";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtTeret
            // 
            // 
            // 
            // 
            this.txtTeret.CustomButton.Image = null;
            this.txtTeret.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtTeret.CustomButton.Name = "";
            this.txtTeret.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTeret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTeret.CustomButton.TabIndex = 1;
            this.txtTeret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTeret.CustomButton.UseSelectable = true;
            this.txtTeret.CustomButton.Visible = false;
            this.txtTeret.Lines = new string[0];
            this.txtTeret.Location = new System.Drawing.Point(319, 404);
            this.txtTeret.MaxLength = 32767;
            this.txtTeret.Name = "txtTeret";
            this.txtTeret.PasswordChar = '\0';
            this.txtTeret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeret.SelectedText = "";
            this.txtTeret.SelectionLength = 0;
            this.txtTeret.SelectionStart = 0;
            this.txtTeret.ShortcutsEnabled = true;
            this.txtTeret.Size = new System.Drawing.Size(113, 23);
            this.txtTeret.TabIndex = 9;
            this.txtTeret.UseSelectable = true;
            this.txtTeret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(146, 326);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Proizvodjac";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(146, 362);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Tip";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(146, 404);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(51, 19);
            this.lblGodina.TabIndex = 12;
            this.lblGodina.Text = "Godina";
            this.lblGodina.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.Location = new System.Drawing.Point(146, 445);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(35, 19);
            this.lblBoja.TabIndex = 13;
            this.lblBoja.Text = "Boja";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(438, 326);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Vlasnik";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(438, 362);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Snaga";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(438, 404);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Tezina tereta";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(24, 363);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(115, 21);
            this.cmbTip.TabIndex = 17;
            // 
            // cmbBoja
            // 
            this.cmbBoja.FormattingEnabled = true;
            this.cmbBoja.Location = new System.Drawing.Point(23, 447);
            this.cmbBoja.Name = "cmbBoja";
            this.cmbBoja.Size = new System.Drawing.Size(116, 21);
            this.cmbBoja.TabIndex = 19;
            // 
            // cmbVlasnik
            // 
            this.cmbVlasnik.FormattingEnabled = true;
            this.cmbVlasnik.Location = new System.Drawing.Point(319, 324);
            this.cmbVlasnik.Name = "cmbVlasnik";
            this.cmbVlasnik.Size = new System.Drawing.Size(113, 21);
            this.cmbVlasnik.TabIndex = 21;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroButton2.Location = new System.Drawing.Point(604, 322);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "Putnicka";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroButton3.Location = new System.Drawing.Point(700, 322);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 23;
            this.metroButton3.Text = "Teretna";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.ForeColor = System.Drawing.Color.Black;
            this.btnIzmeni.Location = new System.Drawing.Point(460, 445);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(113, 23);
            this.btnIzmeni.TabIndex = 8;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // lblBrisanje
            // 
            this.lblBrisanje.AutoSize = true;
            this.lblBrisanje.Location = new System.Drawing.Point(601, 414);
            this.lblBrisanje.Name = "lblBrisanje";
            this.lblBrisanje.Size = new System.Drawing.Size(114, 13);
            this.lblBrisanje.TabIndex = 25;
            this.lblBrisanje.Text = "Vozilo za brisanje (ID): ";
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanje.Location = new System.Drawing.Point(604, 445);
            this.btnBrisanje.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(113, 23);
            this.btnBrisanje.TabIndex = 8;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // VozilaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.lblBrisanje);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.cmbVlasnik);
            this.Controls.Add(this.cmbBoja);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblBoja);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtTeret);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtSnaga);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.txtPro);
            this.Controls.Add(this.dgvVozila);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "VozilaForm";
            this.Load += new System.EventHandler(this.VozilaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVozila;
        private MetroFramework.Controls.MetroTextBox txtPro;
        private MetroFramework.Controls.MetroTextBox txtGodina;
        private MetroFramework.Controls.MetroTextBox txtSnaga;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtTeret;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblGodina;
        private MetroFramework.Controls.MetroLabel lblBoja;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbBoja;
        private System.Windows.Forms.ComboBox cmbVlasnik;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label lblBrisanje;
        private System.Windows.Forms.Button btnBrisanje;
    }
}