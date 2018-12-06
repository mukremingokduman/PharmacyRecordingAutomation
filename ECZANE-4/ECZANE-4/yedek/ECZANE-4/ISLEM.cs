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
    public partial class ISLEM : Form
    {
        public ISLEM()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");

        public void listServiceInformation()
        {
            DataTable tableServiceList = new DataTable();
            SqlDataAdapter adapterCarList = new SqlDataAdapter("SELECT * FROM ISLEM", baglanti);
            adapterCarList.Fill(tableServiceList);
            dataGridView1.DataSource = tableServiceList;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ANASAYFA ANA = new ANASAYFA();
            ANA.Show();
            this.Hide();

        }

        private void ISLEM_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AllowUserToAddRows = false;

            this.FormBorderStyle = FormBorderStyle.None;
            listServiceInformation();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdInsertService = new SqlCommand("INSERT INTO ISLEM VALUES (@HASTAAD,@HASTASOYAD,@HASTATC,@HASTATEL,@HASTAADRES,@ILACAD,@KUTUSAYISI,@FIYAT,@STOK)");

            cmdInsertService.Parameters.AddWithValue("@HASTAAD", txtHastaAd.Text);
            cmdInsertService.Parameters.AddWithValue("@HASTASOYAD", txtHastaSoyad.Text);
            cmdInsertService.Parameters.AddWithValue("@HASTATC", txtHastaTC.Text);
            cmdInsertService.Parameters.AddWithValue("@HASTATEL", txtHastaTEL.Text);
            cmdInsertService.Parameters.AddWithValue("@HASTAADRES", txtHastaAdres.Text);
            cmdInsertService.Parameters.AddWithValue("@ILACAD", txtIlacAd.Text);
            cmdInsertService.Parameters.AddWithValue("@KUTUSAYISI", txtKutu.Text);
            cmdInsertService.Parameters.AddWithValue("@FIYAT", txtFIYAT.Text);
            cmdInsertService.Parameters.AddWithValue("@STOK", txtStok.Text);
           

            try
            {
                baglanti.Open();
                cmdInsertService.Connection = baglanti;
                cmdInsertService.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis kaydı yapılırken hata oluştu" + ex);
            }
            finally
            {
                baglanti.Close();
            }
            listServiceInformation();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                SqlCommand cmdUpdateCar = new SqlCommand();
                StringBuilder strUpdate = new StringBuilder("");
                strUpdate.AppendLine("UPDATE ISLEM SET");
                strUpdate.AppendLine("HASTAAD=@HASTAAD,HASTASOYAD =@HASTASOYAD ,HASTATC=@HASTATC,HASTATEL=@HASTATEL,HASTAADRES=@HASTAADRES,ILACAD=@ILACAD,KUTUSAYISI=@KUTUSAYISI,FIYAT=@FIYAT,STOK=@STOK");
                cmdUpdateCar.Parameters.AddWithValue("@HASTAAD", txtHastaAd.Text);
                cmdUpdateCar.Parameters.AddWithValue("@HASTASOYAD", txtHastaSoyad.Text);
                cmdUpdateCar.Parameters.AddWithValue("@HASTATC", txtHastaTC.Text);
                cmdUpdateCar.Parameters.AddWithValue("@HASTATEL", txtHastaTEL.Text);
                cmdUpdateCar.Parameters.AddWithValue("@HASTAADRES", txtHastaAdres.Text);
                cmdUpdateCar.Parameters.AddWithValue("@ILACAD", txtIlacAd.Text);
                cmdUpdateCar.Parameters.AddWithValue("@KUTUSAYISI", txtKutu.Text);
                cmdUpdateCar.Parameters.AddWithValue("@FIYAT", txtFIYAT.Text);
                cmdUpdateCar.Parameters.AddWithValue("@STOK", txtStok.Text);
               
                strUpdate.AppendLine("WHERE ISLEMID=@ISLEMID");
                cmdUpdateCar.CommandText = strUpdate.ToString();
                cmdUpdateCar.Parameters.AddWithValue("@ISLEMID", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                try
                {
                    baglanti.Open();
                    cmdUpdateCar.Connection = baglanti;
                    cmdUpdateCar.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Güncelleme işlemi yapılırken Hata oluştu");
                }
                finally
                {
                    baglanti.Close();
                }
                listServiceInformation();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHastaAd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtHastaSoyad.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtHastaTC.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtHastaTEL.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtHastaAdres.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtIlacAd.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtKutu.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtFIYAT.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtStok.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
          
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                SqlCommand cmdDeleteCar = new SqlCommand("DELETE FROM ISLEM WHERE ISLEMID=@ISLEMID");
                //StringBuilder strDelete = new StringBuilder("");
                //strDelete.AppendLine("DELETE FROM ARACLAR");
                //strDelete.AppendLine("WHERE ARACID=@ARACID");
                //cmdDeleteCar.CommandText = strDelete.ToString();
                cmdDeleteCar.Parameters.AddWithValue("@ISLEMID", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                try
                {
                    baglanti.Open();
                    cmdDeleteCar.Connection = baglanti;
                    cmdDeleteCar.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi yapılırken hata oluştu" + ex);
                }
                finally
                {
                    baglanti.Close();
                }
                listServiceInformation();
            }
            else
            {
                MessageBox.Show("Silme işlemi için ilac seçmelisiniz.");
            }
        }

        private void btnSilinen_Click(object sender, EventArgs e)
        {
            SILINENKAYITLAR SIL = new SILINENKAYITLAR();
            SIL.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = txtTime.Text.Substring(1) + txtTime.Text.Substring(0,1);
        }

        private void btnANA_Click(object sender, EventArgs e)
        {
            ANASAYFA ANA = new ANASAYFA();
            ANA.Show();
            this.Hide();
        }




    }
}
