using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECZANE_4
{
    public partial class ANASAYFA : Form
    {
        public ANASAYFA()
        {
            InitializeComponent();
        }

        private void btnADMIN_Click(object sender, EventArgs e)
        {
            ADMIN ADM = new ADMIN();
            ADM.Show();
            this.Hide();

        }

        private void btnPERSONEL_Click(object sender, EventArgs e)
        {
            PERSONEL PER = new PERSONEL();
            PER.Show();
            this.Hide();

        }

        private void btnILAC_Click(object sender, EventArgs e)
        {
            ILACEKLE L = new ILACEKLE();
            L.Show();
            this.Hide();
        }

        private void btnHASTA_Click(object sender, EventArgs e)
        {
            HASTA HAS = new HASTA();
            HAS.Show();
            this.Hide();

        }

        private void btnISLEM_Click(object sender, EventArgs e)
        {
            ISLEM IS = new ISLEM();
            IS.Show();
            this.Hide();
        }

        private void btnSILINENKAYIT_Click(object sender, EventArgs e)
        {
            SILINENKAYITLAR SIL = new SILINENKAYITLAR();
            SIL.Show();
            this.Hide();
        }

        private void btnNOBETCI_Click(object sender, EventArgs e)
        {
            NOBETCI N = new NOBETCI();
            N.Show();
            this.Hide();
        }

        private void btnRAPOR_Click(object sender, EventArgs e)
        {
            RAPOR R = new RAPOR();
            R.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = txtTime.Text.Substring(1) + txtTime.Text.Substring(0, 1);
            
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {
            timer1.Start();

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

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
