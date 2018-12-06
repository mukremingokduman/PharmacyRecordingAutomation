namespace ECZANE_4
{
    partial class ILACEKLE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ILACEKLE));
            this.URUNAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIRMAADI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SATISFIYAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ILACID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KDVORANI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RECETETURU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RAFOMRU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnANA = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ara = new System.Windows.Forms.Button();
            this.btnVeriGoster = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtRecete = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblaAdres = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.comboKDV = new System.Windows.Forms.ComboBox();
            this.txtRAF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblsaat = new System.Windows.Forms.Label();
            this.STOK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTOK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // URUNAD
            // 
            this.URUNAD.Text = "URUNAD";
            this.URUNAD.Width = 125;
            // 
            // FIRMAADI
            // 
            this.FIRMAADI.Text = "FIRMAADI";
            this.FIRMAADI.Width = 118;
            // 
            // SATISFIYAT
            // 
            this.SATISFIYAT.Text = "SATISFIYAT";
            this.SATISFIYAT.Width = 109;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ILACID,
            this.URUNAD,
            this.FIRMAADI,
            this.SATISFIYAT,
            this.KDVORANI,
            this.RECETETURU,
            this.RAFOMRU,
            this.STOK});
            this.listView1.Location = new System.Drawing.Point(50, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(829, 121);
            this.listView1.TabIndex = 94;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ILACID
            // 
            this.ILACID.Text = "ILACID";
            this.ILACID.Width = 59;
            // 
            // KDVORANI
            // 
            this.KDVORANI.Text = "KDVORANI";
            this.KDVORANI.Width = 113;
            // 
            // RECETETURU
            // 
            this.RECETETURU.Text = "RECETETURU";
            this.RECETETURU.Width = 114;
            // 
            // RAFOMRU
            // 
            this.RAFOMRU.Text = "RAFOMRU";
            this.RAFOMRU.Width = 143;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTemizle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(189, 321);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(91, 62);
            this.btnTemizle.TabIndex = 115;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGüncelle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGüncelle.Location = new System.Drawing.Point(189, 244);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(91, 67);
            this.btnGüncelle.TabIndex = 114;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSil.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(50, 321);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 62);
            this.btnSil.TabIndex = 113;
            this.btnSil.Text = "SiL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnANA
            // 
            this.btnANA.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnANA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnANA.BackgroundImage")));
            this.btnANA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnANA.Location = new System.Drawing.Point(12, 174);
            this.btnANA.Name = "btnANA";
            this.btnANA.Size = new System.Drawing.Size(51, 53);
            this.btnANA.TabIndex = 121;
            this.btnANA.UseVisualStyleBackColor = false;
            this.btnANA.Click += new System.EventHandler(this.btnANA_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Purple;
            this.btnCikis.Location = new System.Drawing.Point(828, 369);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(51, 55);
            this.btnCikis.TabIndex = 120;
            this.btnCikis.Text = ">>> EXiT >>>";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(779, 317);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "Ad :";
            // 
            // Ara
            // 
            this.Ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ara.Location = new System.Drawing.Point(746, 265);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(133, 48);
            this.Ara.TabIndex = 116;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = false;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // btnVeriGoster
            // 
            this.btnVeriGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVeriGoster.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeriGoster.Location = new System.Drawing.Point(50, 243);
            this.btnVeriGoster.Name = "btnVeriGoster";
            this.btnVeriGoster.Size = new System.Drawing.Size(91, 67);
            this.btnVeriGoster.TabIndex = 112;
            this.btnVeriGoster.Text = "Verileri Göster";
            this.btnVeriGoster.UseVisualStyleBackColor = false;
            this.btnVeriGoster.Click += new System.EventHandler(this.btnVeriGoster_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(534, 369);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(174, 55);
            this.btnKaydet.TabIndex = 110;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtRecete
            // 
            this.txtRecete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRecete.Location = new System.Drawing.Point(531, 270);
            this.txtRecete.Name = "txtRecete";
            this.txtRecete.Size = new System.Drawing.Size(168, 20);
            this.txtRecete.TabIndex = 131;
            // 
            // txtFirma
            // 
            this.txtFirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFirma.Location = new System.Drawing.Point(535, 172);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(167, 20);
            this.txtFirma.TabIndex = 128;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUrunAd.Location = new System.Drawing.Point(536, 143);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(167, 20);
            this.txtUrunAd.TabIndex = 127;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTC.Location = new System.Drawing.Point(370, 202);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(156, 24);
            this.lblTC.TabIndex = 126;
            this.lblTC.Text = "SATIS FIYAT :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.Location = new System.Drawing.Point(397, 172);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(134, 24);
            this.lblSoyad.TabIndex = 125;
            this.lblSoyad.Text = "FIRMA ADI :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(359, 270);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(166, 24);
            this.lblTelefon.TabIndex = 124;
            this.lblTelefon.Text = "RECETE TURU :";
            // 
            // lblaAdres
            // 
            this.lblaAdres.AutoSize = true;
            this.lblaAdres.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaAdres.Location = new System.Drawing.Point(359, 230);
            this.lblaAdres.Name = "lblaAdres";
            this.lblaAdres.Size = new System.Drawing.Size(172, 24);
            this.lblaAdres.TabIndex = 123;
            this.lblaAdres.Text = "KDV ORANI(%) :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(405, 143);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(123, 24);
            this.lblAd.TabIndex = 122;
            this.lblAd.Text = "URUN ADI :";
            // 
            // txtSatis
            // 
            this.txtSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSatis.Location = new System.Drawing.Point(536, 207);
            this.txtSatis.MaxLength = 11;
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(168, 20);
            this.txtSatis.TabIndex = 130;
            // 
            // comboKDV
            // 
            this.comboKDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboKDV.FormattingEnabled = true;
            this.comboKDV.Items.AddRange(new object[] {
            "8",
            "18 "});
            this.comboKDV.Location = new System.Drawing.Point(533, 232);
            this.comboKDV.Name = "comboKDV";
            this.comboKDV.Size = new System.Drawing.Size(166, 21);
            this.comboKDV.TabIndex = 132;
            // 
            // txtRAF
            // 
            this.txtRAF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRAF.Location = new System.Drawing.Point(531, 307);
            this.txtRAF.Name = "txtRAF";
            this.txtRAF.Size = new System.Drawing.Size(168, 20);
            this.txtRAF.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 133;
            this.label2.Text = "RAF OMRU(YIL) :";
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Location = new System.Drawing.Point(25, 155);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(0, 13);
            this.lblsaat.TabIndex = 135;
            // 
            // STOK
            // 
            this.STOK.Text = "STOK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 136;
            this.label3.Text = "STOK :";
            // 
            // txtSTOK
            // 
            this.txtSTOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSTOK.Location = new System.Drawing.Point(531, 343);
            this.txtSTOK.MaxLength = 11;
            this.txtSTOK.Name = "txtSTOK";
            this.txtSTOK.Size = new System.Drawing.Size(168, 20);
            this.txtSTOK.TabIndex = 137;
            // 
            // ILACEKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSTOK);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.txtRAF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboKDV);
            this.Controls.Add(this.txtRecete);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblaAdres);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtSatis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnANA);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.btnVeriGoster);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listView1);
            this.Name = "ILACEKLE";
            this.Text = "ILACEKLE";
            this.Load += new System.EventHandler(this.ILACEKLE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader URUNAD;
        private System.Windows.Forms.ColumnHeader FIRMAADI;
        private System.Windows.Forms.ColumnHeader SATISFIYAT;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ILACID;
        private System.Windows.Forms.ColumnHeader KDVORANI;
        private System.Windows.Forms.ColumnHeader RECETETURU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnANA;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.Button btnVeriGoster;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtRecete;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblaAdres;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSatis;
        private System.Windows.Forms.ComboBox comboKDV;
        private System.Windows.Forms.TextBox txtRAF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader RAFOMRU;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.ColumnHeader STOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSTOK;
    }
}