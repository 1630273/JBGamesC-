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
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            di1.BringToFront();
        }

        private void FormMenuJ_Load(object sender, EventArgs e)
        {

        }

      

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form p = new FormLoginD();
            p.Show();
            this.Hide();
        }


        

        private void btnInicio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            di1.BringToFront();
        }

        private void btnAg_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            da1.BringToFront();

          
        }

        private void btnmo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            dm1.BringToFront();
        }

        private void btnel_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            de1.BringToFront();
        }

        private void da1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnmenubar_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 55)
            {
                //EXPAND
                sidemenu.Visible = true;
                sidemenu.Width = 260;


            }
            else
            {
                //Minimize

                sidemenu.Visible = true;
                sidemenu.Width = 55;


            }
        }
    }
}
