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
    public partial class SILINENKAYITLAR : Form
    {
        public SILINENKAYITLAR()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            ANASAYFA ANA = new ANASAYFA();
            ANA.Show();
            this.Hide();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
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

        private void SILINENKAYITLAR_Load(object sender, EventArgs e)
        {
           /* dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AllowUserToAddRows = false;

            DataTable tableCarList = new DataTable();
            SqlDataAdapter adapterCarList = new SqlDataAdapter("SELECT * FROM YAPILANISLEM", baglanti);
            adapterCarList.Fill(tableCarList);
            dataGridView1.DataSource = tableCarList;
            this.FormBorderStyle = FormBorderStyle.None;
        
            */ 
            }
    }
}
