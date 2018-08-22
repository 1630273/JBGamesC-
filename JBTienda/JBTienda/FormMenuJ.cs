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

            ConsultarNombre(Variables.usuario) ;

        }

       

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FormLoginD p = new FormLoginD();
            p.Show();
            this.Hide();
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
    }
}
