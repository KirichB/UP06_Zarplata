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
    public partial class Sotrydnik : Form
    {
        public Sotrydnik()
        {
            InitializeComponent();
        }

        private void Vihod_sotrudnik_Click(object sender, EventArgs e)
        {
            Avtorizaciya form1 = new Avtorizaciya();
            form1.Show();
            this.Hide();
        }
    }
}
