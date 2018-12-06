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
    public partial class NOBETCI : Form
    {
        public NOBETCI()
        {
            InitializeComponent();
        }

        private void btnIST_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.istanbulsaglik.gov.tr/Index_Nobetci.asp");
        }

        private void btnANK_Click(object sender, EventArgs e)
        {
            //http://www.asm.gov.tr/eczane.htm
            webBrowser1.Navigate("http://www.asm.gov.tr/eczane.htm");
        }

        private void btnIZMIR_Click(object sender, EventArgs e)
        {
            //https://www.izmir.bel.tr/NobetciEczaneler/162/tr
            webBrowser1.Navigate("https://www.izmir.bel.tr/NobetciEczaneler/162/tr");
        }

        private void btnSAK_Click(object sender, EventArgs e)
        {
            //http://www.sakarya.bel.tr/a/EBelediye/NobetciEczaneler

            webBrowser1.Navigate("http://www.sakarya.bel.tr/a/EBelediye/NobetciEczaneler");
        }

        private void btnBURSA_Click(object sender, EventArgs e)
        {
            //http://beo.org.tr/sayfa/23828/nobetci_eczaneler
            webBrowser1.Navigate("http://beo.org.tr/sayfa/23828/nobetci_eczaneler");

        }

        private void btnDUZ_Click(object sender, EventArgs e)
        {
            //http://duzceeo.org/nobetKarti.asp
            webBrowser1.Navigate("http://duzceeo.org/nobetKarti.asp");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ANASAYFA ANS = new ANASAYFA();
            ANS.Show();
            this.Hide();


        }
    }
}
