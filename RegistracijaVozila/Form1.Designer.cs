namespace RegistracijaVozila
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbVozilo = new System.Windows.Forms.PictureBox();
            this.pbVlasnik = new System.Windows.Forms.PictureBox();
            this.pbOrg = new System.Windows.Forms.PictureBox();
            this.pbRad = new System.Windows.Forms.PictureBox();
            this.pbReg = new System.Windows.Forms.PictureBox();
            this.mlbOrg = new MetroFramework.Controls.MetroLabel();
            this.mlbRad = new MetroFramework.Controls.MetroLabel();
            this.mlbReg = new MetroFramework.Controls.MetroLabel();
            this.mlbVoz = new MetroFramework.Controls.MetroLabel();
            this.mlbVlas = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbVozilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVlasnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVozilo
            // 
            this.pbVozilo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVozilo.Image = ((System.Drawing.Image)(resources.GetObject("pbVozilo.Image")));
            this.pbVozilo.Location = new System.Drawing.Point(202, 291);
            this.pbVozilo.Name = "pbVozilo";
            this.pbVozilo.Size = new System.Drawing.Size(153, 138);
            this.pbVozilo.TabIndex = 0;
            this.pbVozilo.TabStop = false;
            this.pbVozilo.Click += new System.EventHandler(this.pbVozilo_Click);
            // 
            // pbVlasnik
            // 
            this.pbVlasnik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVlasnik.Image = ((System.Drawing.Image)(resources.GetObject("pbVlasnik.Image")));
            this.pbVlasnik.Location = new System.Drawing.Point(441, 291);
            this.pbVlasnik.Name = "pbVlasnik";
            this.pbVlasnik.Size = new System.Drawing.Size(139, 138);
            this.pbVlasnik.TabIndex = 1;
            this.pbVlasnik.TabStop = false;
            this.pbVlasnik.Click += new System.EventHandler(this.pbVlasnik_Click_1);
            // 
            // pbOrg
            // 
            this.pbOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOrg.Image = ((System.Drawing.Image)(resources.GetObject("pbOrg.Image")));
            this.pbOrg.Location = new System.Drawing.Point(124, 78);
            this.pbOrg.Name = "pbOrg";
            this.pbOrg.Size = new System.Drawing.Size(144, 144);
            this.pbOrg.TabIndex = 2;
            this.pbOrg.TabStop = false;
            this.pbOrg.Click += new System.EventHandler(this.pbOrg_Click_1);
            // 
            // pbRad
            // 
            this.pbRad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRad.Image = ((System.Drawing.Image)(resources.GetObject("pbRad.Image")));
            this.pbRad.Location = new System.Drawing.Point(324, 78);
            this.pbRad.Name = "pbRad";
            this.pbRad.Size = new System.Drawing.Size(143, 144);
            this.pbRad.TabIndex = 3;
            this.pbRad.TabStop = false;
            this.pbRad.Click += new System.EventHandler(this.pbRad_Click_1);
            // 
            // pbReg
            // 
            this.pbReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReg.Image = ((System.Drawing.Image)(resources.GetObject("pbReg.Image")));
            this.pbReg.Location = new System.Drawing.Point(516, 78);
            this.pbReg.Name = "pbReg";
            this.pbReg.Size = new System.Drawing.Size(141, 144);
            this.pbReg.TabIndex = 4;
            this.pbReg.TabStop = false;
            this.pbReg.Click += new System.EventHandler(this.pbReg_Click);
            // 
            // mlbOrg
            // 
            this.mlbOrg.AutoSize = true;
            this.mlbOrg.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbOrg.Location = new System.Drawing.Point(150, 240);
            this.mlbOrg.Name = "mlbOrg";
            this.mlbOrg.Size = new System.Drawing.Size(93, 19);
            this.mlbOrg.TabIndex = 5;
            this.mlbOrg.Text = "Organizacije";
            this.mlbOrg.UseCustomBackColor = true;
            // 
            // mlbRad
            // 
            this.mlbRad.AutoSize = true;
            this.mlbRad.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbRad.Location = new System.Drawing.Point(368, 240);
            this.mlbRad.Name = "mlbRad";
            this.mlbRad.Size = new System.Drawing.Size(58, 19);
            this.mlbRad.TabIndex = 6;
            this.mlbRad.Text = "Radnici";
            this.mlbRad.UseCustomBackColor = true;
            // 
            // mlbReg
            // 
            this.mlbReg.AutoSize = true;
            this.mlbReg.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbReg.Location = new System.Drawing.Point(547, 240);
            this.mlbReg.Name = "mlbReg";
            this.mlbReg.Size = new System.Drawing.Size(87, 19);
            this.mlbReg.TabIndex = 7;
            this.mlbReg.Text = "Registracije";
            this.mlbReg.UseCustomBackColor = true;
            // 
            // mlbVoz
            // 
            this.mlbVoz.AutoSize = true;
            this.mlbVoz.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbVoz.Location = new System.Drawing.Point(252, 444);
            this.mlbVoz.Name = "mlbVoz";
            this.mlbVoz.Size = new System.Drawing.Size(49, 19);
            this.mlbVoz.TabIndex = 8;
            this.mlbVoz.Text = "Vozila";
            this.mlbVoz.UseCustomBackColor = true;
            // 
            // mlbVlas
            // 
            this.mlbVlas.AutoSize = true;
            this.mlbVlas.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbVlas.Location = new System.Drawing.Point(483, 444);
            this.mlbVlas.Name = "mlbVlas";
            this.mlbVlas.Size = new System.Drawing.Size(59, 19);
            this.mlbVlas.TabIndex = 9;
            this.mlbVlas.Text = "Vlasnici";
            this.mlbVlas.UseCustomBackColor = true;
            // 
            // Form1
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackMaxSize = 1000;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.mlbVlas);
            this.Controls.Add(this.mlbVoz);
            this.Controls.Add(this.mlbReg);
            this.Controls.Add(this.mlbRad);
            this.Controls.Add(this.mlbOrg);
            this.Controls.Add(this.pbReg);
            this.Controls.Add(this.pbRad);
            this.Controls.Add(this.pbOrg);
            this.Controls.Add(this.pbVlasnik);
            this.Controls.Add(this.pbVozilo);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVozilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVlasnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVozilo;
        private System.Windows.Forms.PictureBox pbVlasnik;
        private System.Windows.Forms.PictureBox pbOrg;
        private System.Windows.Forms.PictureBox pbRad;
        private System.Windows.Forms.PictureBox pbReg;
        private MetroFramework.Controls.MetroLabel mlbOrg;
        private MetroFramework.Controls.MetroLabel mlbRad;
        private MetroFramework.Controls.MetroLabel mlbReg;
        private MetroFramework.Controls.MetroLabel mlbVoz;
        private MetroFramework.Controls.MetroLabel mlbVlas;
    }
}

