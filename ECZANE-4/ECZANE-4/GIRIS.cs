﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace ECZANE_4
{
    public partial class GIRIS : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");

        public GIRIS()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "SELECT * FROM GIRIS WHERE KULLANICIADI=@KULLANICIADI AND PAROLA =@PAROLA ";
                SqlParameter prm1 = new SqlParameter("KULLANICIADI", txtKullanici.Text);
                SqlParameter prm2 = new SqlParameter("PAROLA", txtSifre.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);


                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
               /* this.FormBorderStyle = FormBorderStyle.None;
                txtKullanici.Text = "ADMIN";
                txtSifre.Text = "1234";
               */
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ANASAYFA ANA = new ANASAYFA();
                    ANA.Show();
                    this.Hide();
                }

               


            }

            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş Yaptınız Kullanıcı Adınızı veya Parolanızı Kontrol Ediniz ");
           /*      this.FormBorderStyle = FormBorderStyle.None;
                txtKullanici.Text = "ADMIN";
                txtSifre.Text = "1234";
                */
            }

          
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
    }
}
