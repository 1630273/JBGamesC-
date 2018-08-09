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
    public partial class FormMCliente : Form
    {
        public FormMCliente()
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

        }

        private void btnEle_Click(object sender, EventArgs e)
        {

        }

        private void btnSalud_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

       
        
    }
}
