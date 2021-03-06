﻿using System;
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
    public partial class MenuPrincipalGerente : Form
    {
        public MenuPrincipalGerente()
        {
            InitializeComponent();

            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            di1.BringToFront();
        }

        private void FormMenuJ_Load(object sender, EventArgs e)
        {
            if (VerificarConexion() == true)
            {
                MessageBox.Show("Conexion Extablecida");
                ConsultarNombre(Variables.usuario);

            }
            else
            {
                MessageBox.Show("Error de Conexion, Pongase en contacto con el Administrador");

                Application.Exit();

            }
        }


        public bool VerificarConexion()
        {
            bool verificacion;


            if (Variables.con == true && Variables.con1 == true)
            {
               // MessageBox.Show("True");
                verificacion = true;

            }
            else
            {
                //MessageBox.Show("False");
                verificacion = false;

            }

            return verificacion;

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
            MenuIniciarSesion p = new MenuIniciarSesion();
            p.Show();
            this.Hide();

            }

           
        }

        void ConsultarNombre(string usu)
        {

            dcTiendaDataContext dc = new dcTiendaDataContext();
            var nom = from con in dc.consultarNombreGerentes(usu)
                      select con;

            foreach (var n in nom)
            {
                lblNombre.Text = n.NombreCompleto;

            }
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInicio.Height;
            SidePanel.Top = btnInicio.Top;
            di1.BringToFront();
        }

        private void btnAg_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAg.Height;
            SidePanel.Top = btnAg.Top;
            da1.BringToFront();
        }

        private void btnmo_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btnmo.Height;
            SidePanel.Top = btnmo.Top;
            dm1.BringToFront();
        }

        private void btnel_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnel.Height;
            SidePanel.Top = btnel.Top;
            de1.BringToFront();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void da1_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process ayuda = new System.Diagnostics.Process();
            ayuda.StartInfo.FileName = "C:\\Users\\julii\\Desktop\\ManualUsuario\\ManualAyuda_MenuGerente.pdf";
            ayuda.Start();
            ayuda.Close();
        }

        private void MenuPrincipalGerente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process ayuda = new System.Diagnostics.Process();
                ayuda.StartInfo.FileName = "C:\\Users\\julii\\Desktop\\ManualUsuario\\ManualAyuda_MenuGerente.pdf";
                ayuda.Start();
                ayuda.Close();
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
                    MenuIniciarSesion p = new MenuIniciarSesion();
                    p.Show();
                    this.Hide();

                }

                
            }
        }
    }
}
