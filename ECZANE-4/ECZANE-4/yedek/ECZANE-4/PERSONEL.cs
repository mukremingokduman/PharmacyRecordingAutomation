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
    public partial class PERSONEL : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");

        public PERSONEL()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into PERSONEL (PERSONELAD,PERSONELSOYAD,KULLANICIADI,PAROLA,KULLANICITIPI) values (' " + txtAd.Text + "','" + txtSoyad.Text + "','" + txtKullaniciADI.Text+ "','" + txtParola.Text + "','" + comboTIP.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }

        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PERSONEL", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["PERSONELID"].ToString();
                ekle.SubItems.Add(oku["PERSONELAD"].ToString());
                ekle.SubItems.Add(oku["PERSONELSOYAD"].ToString());
                ekle.SubItems.Add(oku["KULLANICIADI"].ToString());
                ekle.SubItems.Add(oku["PAROLA"].ToString());
                ekle.SubItems.Add(oku["KULLANICITIPI"].ToString());

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
            SqlCommand komut = new SqlCommand("select * from PERSONEL where PERSONELAD like '½ " + txtAra.Text + "½'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["PERSONELID"].ToString();
                ekle.SubItems.Add(oku["PERSONELAD"].ToString());
                ekle.SubItems.Add(oku["PERSONELSOYAD"].ToString());
                ekle.SubItems.Add(oku["KULLANICIADI"].ToString());
                ekle.SubItems.Add(oku["PAROLA"].ToString());
                ekle.SubItems.Add(oku["KULLANICITIPI"].ToString());

                listView1.Items.Add(ekle);


            }

            baglanti.Close();
        }
        int ID = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
           txtKullaniciADI.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtParola.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboTIP.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from PERSONEL where PERSONELID=(" + ID + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtKullaniciADI.Clear();
            txtParola.Clear();
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update PERSONEL set PERSONELAD= '" + txtAd.Text + "',PERSONELSOYAD='" + txtSoyad.Text + "',KULLANICIADI= '" + txtKullaniciADI.Text + "',PAROLA='" + txtParola.Text + "',KULLANICITIPI='" + comboTIP.Text + "' where PERSONELID=" + ID + "", baglanti);
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

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            ANASAYFA ANA = new ANASAYFA();
            ANA.Show();
            this.Hide();
        }






    }
}
