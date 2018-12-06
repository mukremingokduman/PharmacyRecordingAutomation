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
    public partial class RAPOR : Form
    {
        public RAPOR()
        {
            InitializeComponent();
        }
        string menü;
        private void btnListele_Click(object sender, EventArgs e)
        {
            menü = comboBox1.SelectedItem.ToString();

            if (menü == "HASTALARI LISTELE")
            {

                SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from HASTA ", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();


            }
            else if (menü == "PERSONELLERI LISTELE")
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from PERSONEL ", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();




            }
            else if (menü == "ILACLARI LISTELE")
            {

                SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from ILAC ", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();


            }
            

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int StartCol = 1;

            int StartRow = 1;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];

                myRange.Value2 = dataGridView1.Columns[j].HeaderText;

            }

            StartRow++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    try
                    {

                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];

                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;

                    }

                    catch
                    { ;}

                }

            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
          /*  PERSONEL PER = new PERSONEL();
            int ID = PER.PERSONELID; 

            string yetki;
            SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT KULLANICITIPI FROM PERSONEL WHERE PERSENELID=" + PER.PERSONELID + "", baglanti);

            SqlDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();
            KULLANICITIPI = dr2.GetString(0).ToString();


             if (KULLANITIPI == "ADMIN")
             {
                 ADMIN ADM = new ADMIN();
                 ADM.Show();

             
             }
              else
              
            {
                ANASAYFA ANA = new ANASAYFA();
                ANA.Show();


            }

            baglanti.Close();   */



            ANASAYFA ANA = new ANASAYFA();
            ANA.Show();
        }

        private void btnANA_Click(object sender, EventArgs e)
        {
            ANASAYFA ANA = new ANASAYFA();
            ANA.Show();
            this.Hide();
        }
    }
}
