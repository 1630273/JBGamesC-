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
    public partial class MenuPrincipalAdmin : Form
    {
        public MenuPrincipalAdmin()
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

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
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

        private void aej1_Load(object sender, EventArgs e)
        {

        }

        private void sidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            string message = "Estas seguro de cerrar sesión?";
            string caption = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();
                Form p = new MenuIniciarSesion();
                p.Show();
                this.Hide();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ayuda = new System.Diagnostics.Process();
            ayuda.StartInfo.FileName = "C:\\Users\\julii\\Desktop\\ManualUsuario\\ManualAyuda_MenuAdmin.pdf";
            ayuda.Start();
            ayuda.Close();
        }

      

        private void MenuPrincipalAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

                System.Diagnostics.Process ayuda = new System.Diagnostics.Process();
                ayuda.StartInfo.FileName = "C:\\Users\\julii\\Desktop\\ManualUsuario\\ManualAyuda_MenuAdmin.pdf";
                ayuda.Start();
                ayuda.Close();
            }

            if(e.KeyCode == Keys.Escape)
            {
                string message = "Estas seguro de cerrar sesión?";
                string caption = "Salir";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    this.Close();
                    Form p = new MenuIniciarSesion();
                    p.Show();
                    this.Hide();
                }
            }

            if(e.KeyCode == Keys.F2)
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
}
