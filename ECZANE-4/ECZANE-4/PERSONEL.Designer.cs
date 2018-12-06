namespace ECZANE_4
{
    partial class PERSONEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PERSONEL));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PERSONELID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PERSONELAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PERSONELSOYAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KULLANICIADI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PAROLA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KULLANICITIPI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVeriGoster = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKullaniciADI = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblaAdres = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTIP = new System.Windows.Forms.ComboBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ara = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Purple;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(795, 371);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(53, 59);
            this.btnCikis.TabIndex = 80;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAnaSayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.BackgroundImage")));
            this.btnAnaSayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(679, 42);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(115, 102);
            this.btnAnaSayfa.TabIndex = 79;
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PERSONELID,
            this.PERSONELAD,
            this.PERSONELSOYAD,
            this.KULLANICIADI,
            this.PAROLA,
            this.KULLANICITIPI});
            this.listView1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(21, 279);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(777, 158);
            this.listView1.TabIndex = 78;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // PERSONELID
            // 
            this.PERSONELID.Text = "PERSONEL  ID";
            this.PERSONELID.Width = 106;
            // 
            // PERSONELAD
            // 
            this.PERSONELAD.Text = "PERSONEL  AD";
            this.PERSONELAD.Width = 116;
            // 
            // PERSONELSOYAD
            // 
            this.PERSONELSOYAD.Text = "PERSONEL   SOYAD";
            this.PERSONELSOYAD.Width = 142;
            // 
            // KULLANICIADI
            // 
            this.KULLANICIADI.Text = "KULLANICI  ADI";
            this.KULLANICIADI.Width = 129;
            // 
            // PAROLA
            // 
            this.PAROLA.Text = "PAROLA";
            this.PAROLA.Width = 113;
            // 
            // KULLANICITIPI
            // 
            this.KULLANICITIPI.Text = "KULLANICI   TIPI";
            this.KULLANICITIPI.Width = 149;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemizle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(508, 19);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(133, 48);
            this.btnTemizle.TabIndex = 77;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGüncelle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGüncelle.Location = new System.Drawing.Point(508, 128);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(133, 48);
            this.btnGüncelle.TabIndex = 76;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSil.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(508, 229);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 44);
            this.btnSil.TabIndex = 75;
            this.btnSil.Text = "SiL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVeriGoster
            // 
            this.btnVeriGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVeriGoster.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriGoster.Location = new System.Drawing.Point(30, 229);
            this.btnVeriGoster.Name = "btnVeriGoster";
            this.btnVeriGoster.Size = new System.Drawing.Size(133, 44);
            this.btnVeriGoster.TabIndex = 74;
            this.btnVeriGoster.Text = "Verileri Göster";
            this.btnVeriGoster.UseVisualStyleBackColor = false;
            this.btnVeriGoster.Click += new System.EventHandler(this.btnVeriGoster_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKaydet.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(271, 229);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 44);
            this.btnKaydet.TabIndex = 72;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKullaniciADI
            // 
            this.txtKullaniciADI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKullaniciADI.Location = new System.Drawing.Point(254, 97);
            this.txtKullaniciADI.Name = "txtKullaniciADI";
            this.txtKullaniciADI.Size = new System.Drawing.Size(168, 20);
            this.txtKullaniciADI.TabIndex = 70;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSoyad.Location = new System.Drawing.Point(254, 63);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(167, 20);
            this.txtSoyad.TabIndex = 69;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAd.Location = new System.Drawing.Point(255, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(167, 20);
            this.txtAd.TabIndex = 68;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.Location = new System.Drawing.Point(26, 63);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(209, 24);
            this.lblSoyad.TabIndex = 66;
            this.lblSoyad.Text = "PERSONEL Soyad :";
            // 
            // lblaAdres
            // 
            this.lblaAdres.AutoSize = true;
            this.lblaAdres.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaAdres.Location = new System.Drawing.Point(26, 97);
            this.lblaAdres.Name = "lblaAdres";
            this.lblaAdres.Size = new System.Drawing.Size(184, 24);
            this.lblaAdres.TabIndex = 64;
            this.lblaAdres.Text = "KULLANICI ADI  :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(26, 29);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(168, 24);
            this.lblAd.TabIndex = 63;
            this.lblAd.Text = "PERSONEL Ad :";
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtParola.Location = new System.Drawing.Point(254, 128);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(168, 20);
            this.txtParola.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "PAROLA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 83;
            this.label2.Text = "KULLANICI TIPI  :";
            // 
            // comboTIP
            // 
            this.comboTIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboTIP.FormattingEnabled = true;
            this.comboTIP.Items.AddRange(new object[] {
            "ADMIN",
            "PERSONEL",
            "MISAFIR"});
            this.comboTIP.Location = new System.Drawing.Point(255, 165);
            this.comboTIP.Name = "comboTIP";
            this.comboTIP.Size = new System.Drawing.Size(167, 21);
            this.comboTIP.TabIndex = 84;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.Location = new System.Drawing.Point(715, 229);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(79, 21);
            this.txtAra.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "Ad :";
            // 
            // Ara
            // 
            this.Ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ara.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ara.Location = new System.Drawing.Point(679, 177);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(119, 48);
            this.Ara.TabIndex = 85;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = false;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(665, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 88;
            // 
            // PERSONEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 442);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.comboTIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVeriGoster);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKullaniciADI);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblaAdres);
            this.Controls.Add(this.lblAd);
            this.Name = "PERSONEL";
            this.Text = "PERSONEL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PERSONELID;
        private System.Windows.Forms.ColumnHeader PERSONELAD;
        private System.Windows.Forms.ColumnHeader PERSONELSOYAD;
        private System.Windows.Forms.ColumnHeader KULLANICIADI;
        private System.Windows.Forms.ColumnHeader PAROLA;
        private System.Windows.Forms.ColumnHeader KULLANICITIPI;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVeriGoster;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtKullaniciADI;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblaAdres;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTIP;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}