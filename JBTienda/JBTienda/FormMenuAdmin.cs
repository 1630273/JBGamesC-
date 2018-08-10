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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            ainicio1.BringToFront();
        }


     
        private void btnmenubar_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 55)
            {
                //EXPAND
                sidemenu.Visible = false;
                sidemenu.Width = 260;
                PanelAnimation.ShowSync(sidemenu);
                LogoAnimation.ShowSync(logo);

            }
            else
            {
                //Minimize
                LogoAnimation.ShowSync(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 55;
                PanelAnimation.ShowSync(sidemenu);

            }
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form p = new FormLoginA();
            p.Show();
            this.Hide();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            ainicio1.BringToFront();
        }

        private void btnCom_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btnCom.Height;
            SidePanel.Top = btnCom.Top;
            acom1.BringToFront();
        }

        private void btnJuego_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btnJuego.Height;
            SidePanel.Top = btnJuego.Top;
            ajuegos1.BringToFront();
        }

        private void btnCel_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCel.Height;
            SidePanel.Top = btnCel.Top;
            ac1.BringToFront();
        }

        private void btnEle_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEle.Height;
            SidePanel.Top = btnEle.Top;
            ael1.BringToFront();
        }

        private void btnSalud_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSalud.Height;
            SidePanel.Top = btnSalud.Top;
            aej1.BringToFront();
        }
    }
}
