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
            ILAC L = new ILAC();
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
    }
}
