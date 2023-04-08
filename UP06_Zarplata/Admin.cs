using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP06_Zarplata
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Vihod_admin_Click(object sender, EventArgs e)
        {
            Avtorizaciya form1 = new Avtorizaciya();
            form1.Show();
            this.Hide();
        }
    }
}
