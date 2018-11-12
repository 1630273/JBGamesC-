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
    public partial class MenuPrincipalCliente : Form
    {
        public MenuPrincipalCliente()
        {
            InitializeComponent();
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            cuinicio1.BringToFront();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            cuinicio1.BringToFront();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            
            SidePanel.Height = btnCom.Height;
            SidePanel.Top = btnCom.Top;
            cucom1.BringToFront();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnJuego.Height;
            SidePanel.Top = btnJuego.Top;
            cujuegos1.BringToFront();
        }

        private void btnCel_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCel.Height;
            SidePanel.Top = btnCel.Top;
            cucelulares1.BringToFront();
        }


        private void btnEle_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEle.Height;
            SidePanel.Top = btnEle.Top;
            cuelectrodomestico1.BringToFront();
        }

        private void btnSalud_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSalud.Height;
            SidePanel.Top = btnSalud.Top;
            cuEjercicio1.BringToFront();
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

        void ConsultarNombre(string usu)
        {

            dcTiendaDataContext dc = new dcTiendaDataContext();
            var nom = from con in dc.consultarNombreCliente(usu)
                      select con;

            foreach (var n in nom)
            {
                lbNombre.Text = n.NombreCompleto;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cujuegos1_Load(object sender, EventArgs e)
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

        private void FormMCliente_Load(object sender, EventArgs e)
        {
            ConsultarNombre(Variables.usuario);
        }


        //Metodo que te lleva al frame del carrito

        private void btncar_Click(object sender, EventArgs e)
        {
            Form car = new FormCarrito();
            car.Show();
            this.Hide();
        }

        private void cuinicio2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
