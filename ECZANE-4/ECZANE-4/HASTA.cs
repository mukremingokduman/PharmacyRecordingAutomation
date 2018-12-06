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
    public partial class HASTA : Form
    {
        public HASTA()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");
        private void HASTA_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into HASTA (HASTAAD,HASTASOYAD,HASTATC,HASTAADRES,HASTATEL) values (' " + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTC.Text + "','" + txtAdres.Text + "','" + txtTell.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }

        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from HASTA", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["HASTAID"].ToString();
                ekle.SubItems.Add(oku["HASTAAD"].ToString());
                ekle.SubItems.Add(oku["HASTASOYAD"].ToString());
                ekle.SubItems.Add(oku["HASTATC"].ToString());
                ekle.SubItems.Add(oku["HASTAADRES"].ToString());
                ekle.SubItems.Add(oku["HASTATEL"].ToString());
                
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
            SqlCommand komut = new SqlCommand("select * from HASTA where HASTAAD like '½ " + txtAra.Text + "½'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["HASTAID"].ToString();
                ekle.SubItems.Add(oku["HASTAAD"].ToString());
                ekle.SubItems.Add(oku["HASTASOYAD"].ToString());
                ekle.SubItems.Add(oku["HASTATC"].ToString());
                ekle.SubItems.Add(oku["HASTAADRES"].ToString());
                ekle.SubItems.Add(oku["HASTATEL"].ToString());

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
            txtTC.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtAdres.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtTell.Text = listView1.SelectedItems[0].SubItems[5].Text;
            
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from HASTA where HASTAID=(" + ID + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTell.Clear();
            txtTC.Clear();
            txtAdres.Clear();

           
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update HASTA set HASTAAD= '" + txtAd.Text + "',HASTASOYAD='" + txtSoyad.Text + "',HASTATC= '" + txtTC.Text + "',HASTAADRES='" + txtAdres.Text + "',HASTATEL='" + txtTell.Text + "' where HASTAID=" + ID + "", baglanti);
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

        private void btnANA_Click(object sender, EventArgs e)
        {
            ANASAYFA ANA = new ANASAYFA();
            ANA.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text=    DateTime.Now.ToLongTimeString();
        }




    }
}
