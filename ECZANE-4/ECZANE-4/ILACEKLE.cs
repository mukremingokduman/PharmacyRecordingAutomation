using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace ECZANE_4
{
    public partial class ILACEKLE : Form
    {
        public ILACEKLE()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ILACEKLE (URUNAD,FIRMAADI,SATISFIYAT,KDVORANI,RECETETURU,RAFOMRU,STOK) values (' " + txtUrunAd.Text + "','" + txtFirma.Text + "','" + txtSatis.Text + "','" + comboKDV.Text + "','" + txtRecete.Text + "','" + txtRAF.Text + "','" + txtSTOK.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ILACEKLE", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ILACID"].ToString();
                ekle.SubItems.Add(oku["URUNAD"].ToString());
                ekle.SubItems.Add(oku["FIRMAADI"].ToString());
                ekle.SubItems.Add(oku["SATISFIYAT"].ToString());
                ekle.SubItems.Add(oku["KDVORANI"].ToString());
                ekle.SubItems.Add(oku["RECETETURU"].ToString());
                ekle.SubItems.Add(oku["RAFOMRU"].ToString());
                ekle.SubItems.Add(oku["STOK"].ToString());
                listView1.Items.Add(ekle);


            }

            baglanti.Close();

        }

        private void btnVeriGoster_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ILACEKLE where URUNAD like '½ " + txtAra.Text + "½'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ILACID"].ToString();
                ekle.SubItems.Add(oku["URUNAD"].ToString());
                ekle.SubItems.Add(oku["FIRMAADI"].ToString());
                ekle.SubItems.Add(oku["SATISFIYAT"].ToString());
                ekle.SubItems.Add(oku["KDVORANI"].ToString());
                ekle.SubItems.Add(oku["RECETETURU"].ToString());
                ekle.SubItems.Add(oku["RAFOMRU"].ToString());
                ekle.SubItems.Add(oku["STOK"].ToString());
                listView1.Items.Add(ekle);

            }

            baglanti.Close();
        }
        int ID = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtUrunAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtFirma.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtSatis.Text = listView1.SelectedItems[0].SubItems[3].Text;
            comboKDV.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtRecete.Text = listView1.SelectedItems[0].SubItems[5].Text;
          txtRAF.Text = listView1.SelectedItems[0].SubItems[6].Text;
          txtSTOK.Text= listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from ILACEKLE where ILACID=(" + ID + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            txtFirma.Clear();
            txtRAF.Clear();
            txtRecete.Clear();
            txtSatis.Clear();
            txtUrunAd.Clear();
            txtSTOK.Clear();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update ILACEKLE set URUNAD= '" + txtUrunAd.Text + "',FIRMAADI='" + txtFirma.Text + "',SATISFIYAT= '" + txtSatis.Text + "',KDVORANI='" + comboKDV.Text + "',RECETETURU='" + txtRecete.Text + "',RAFOMRU='" + txtRAF.Text + "',STOK='" + txtSTOK.Text + "' where ILACID=" + ID + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ?", "Çıkış Ekranı !!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //don't do anything
            }
        }

        private void btnANA_Click(object sender, EventArgs e)
        {
            ANASAYFA ANA = new ANASAYFA();
            ANA.Show();
            this.Hide();
        }

        private void ILACEKLE_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }





    }
}
