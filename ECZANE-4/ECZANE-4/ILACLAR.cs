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
    public partial class ILACLAR : Form
    {
        public ILACLAR()
        {
            InitializeComponent();
        }
        //Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ECZANE-4;Integrated Security=True");
        public void listEczaneBilgi()
        {
            DataTable tableEczaneList = new DataTable();
            SqlDataAdapter adapterEczaneList = new SqlDataAdapter("SELECT ILACID,ILAC.BARKODNO,ILACAD,ILAC.SIGORTAID,HASTAAD,FIRMA,KUTUSAYISI,FIYAT,STOK FROM ILAC INNER JOIN BARKODNO ON ILAC.BARKODNO=BARKOD.BARKODNO INNER JOIN SIGORTA ON SIGORTA.SIGORTAID=ILAC.SIGORTAID  ", baglanti);
            adapterEczaneList.Fill(tableEczaneList);
            gridEczaneBilgi.DataSource = tableEczaneList;
            gridEczaneBilgi.Columns[0].Visible = false;
            gridEczaneBilgi.Columns[1].Visible = false;
            gridEczaneBilgi.Columns[3].Visible = false;
        }

        public void fillEczaneILAC()
        {
            SqlCommand cmdEczaneILAC = new SqlCommand();
            cmdEczaneILAC.CommandText = "SELECT BARKODNO,ILACAD from BARKOD";
            cmdEczaneILAC.Connection = baglanti;
            SqlDataAdapter adapterEczaneILAC = new SqlDataAdapter(cmdEczaneILAC);
            DataTable tableEczaneILAC = new DataTable();
            adapterEczaneILAC.Fill(tableEczaneILAC);
            comboILAC.ValueMember = "BARKODNO";
            comboILAC.DisplayMember = "ILACAD";
            comboILAC.DataSource = tableEczaneILAC;
        }

        public void fillEczaneSIGORTA()
        {
            SqlCommand cmdSIGORTA = new SqlCommand();
            cmdSIGORTA.CommandText = "SELECT SIGORTAID,HASTAAD from SIGORTA WHERE BARKODNO=@BARKODNO";
            cmdSIGORTA.Connection = baglanti;
            cmdSIGORTA.Parameters.AddWithValue("MARKAID", comboFIRMA.SelectedValue);
            SqlDataAdapter adapterECZANEModel = new SqlDataAdapter(cmdSIGORTA);
            DataTable tableCarModel = new DataTable();
            comboFIRMA.ValueMember = "SIGORTAID";
            comboFIRMA.DisplayMember = "HASTAAD";
            adapterECZANEModel.Fill(tableCarModel);
            comboFIRMA.DataSource = tableCarModel;
        }
        public void fillEczaneKUTU()
        {
            comboKUTU.Items.Add("50");
            comboKUTU.Items.Add("100");
            comboKUTU.SelectedIndex = 0;
        }

        private void ILACLAR_Load(object sender, EventArgs e)
        {
            gridEczaneBilgi.EnableHeadersVisualStyles = false;
            gridEczaneBilgi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridEczaneBilgi.AllowUserToAddRows = false;

            listEczaneBilgi();
            fillEczaneILAC();
            fillEczaneSIGORTA();
            fillEczaneKUTU();
            
        }

        private void comboILAC_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillEczaneSIGORTA();
        }

        private void gridEczaneBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ILACAD,HASTAAD,KUTUSAYISI,FIYAT,STOK
            comboILAC.SelectedValue = gridEczaneBilgi.SelectedRows[0].Cells[1].Value.ToString();
            comboILAC.SelectedItem = gridEczaneBilgi.SelectedRows[0].Cells[2].Value.ToString();
            comboFIRMA.SelectedValue = gridEczaneBilgi.SelectedRows[0].Cells[3].Value.ToString();
            comboFIRMA.SelectedItem = gridEczaneBilgi.SelectedRows[0].Cells[4].Value.ToString();
            comboKUTU.SelectedItem = gridEczaneBilgi.SelectedRows[0].Cells[5].Value.ToString();
            txtFIYAT.Text = gridEczaneBilgi.SelectedRows[0].Cells[6].Value.ToString();
            txtSTOK.Text = gridEczaneBilgi.SelectedRows[0].Cells[7].Value.ToString();
            
        }





    }
}
