using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBTienda
{
    public partial class Comopag : UserControl
    {
        public Comopag()
        {
            InitializeComponent();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            Td ir = new Td();
            ir.Show();
            this.Hide();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Tc ir = new Tc();
            ir.Show();
            this.Hide();
        }
    }
}
