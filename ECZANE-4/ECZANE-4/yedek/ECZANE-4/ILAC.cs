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
    public partial class ILAC : Form
    {
        public ILAC()
        {
            InitializeComponent();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            ANASAYFA ANA = new ANASAYFA();
            ANA.Show();
            this.Hide();
        }
    }
}
