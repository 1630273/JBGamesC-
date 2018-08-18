using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBTienda
{
    public partial class FormMenuJ : Form
    {
        public FormMenuJ()
        {
            InitializeComponent();
        }

        private void FormMenuJ_Load(object sender, EventArgs e)
        {

        }

        private void sidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form p = new FormLoginD();
            p.Show();
            this.Hide();
        }
    }
}
