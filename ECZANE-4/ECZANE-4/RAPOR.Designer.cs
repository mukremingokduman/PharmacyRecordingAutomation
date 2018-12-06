namespace ECZANE_4
{
    partial class RAPOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RAPOR));
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnANA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(2, 382);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(69, 42);
            this.btnAnaSayfa.TabIndex = 19;
            this.btnAnaSayfa.Text = "ANA SAYFA";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcel.Location = new System.Drawing.Point(441, 382);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(145, 33);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Excel\'e Aktar";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 312);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(478, 35);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 16;
            this.btnListele.Text = "LISTELE ";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HASTALARI LISTELE",
            "PERSONELI LISTELE",
            "ILACLARI LISTELE",
            "KULLANICILARI LISTELE"});
            this.comboBox1.Location = new System.Drawing.Point(441, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Yapılacak Listeleme işlemini seçiniz :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnANA
            // 
            this.btnANA.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnANA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnANA.BackgroundImage")));
            this.btnANA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnANA.Location = new System.Drawing.Point(825, 5);
            this.btnANA.Name = "btnANA";
            this.btnANA.Size = new System.Drawing.Size(51, 53);
            this.btnANA.TabIndex = 77;
            this.btnANA.UseVisualStyleBackColor = false;
            this.btnANA.Click += new System.EventHandler(this.btnANA_Click);
            // 
            // RAPOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 426);
            this.Controls.Add(this.btnANA);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "RAPOR";
            this.Text = "RAPOR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnANA;
    }
}