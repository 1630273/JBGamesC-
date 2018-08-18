﻿using System;
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
    public partial class Aej : UserControl
    {
        public Aej()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            char idSexo = ' ';
            int idTipoUsuario = 7;
            int idDepartmaneto = 5;

            if (rdoHombre.Checked == true)
            {
                idSexo = 'H';
            }
            else if (rdoMujer.Checked == true)
            {
                idSexo = 'M';
            }

            dcTiendaDataContext dc = new dcTiendaDataContext();
            dc.agregarGerente(
                txtUsuario.Text,
                txtContraseña.Text,
                txtNombre.Text,
                txtApellidoPaterno.Text,
                txtApellidoMaterno.Text,
                idSexo,
                byte.Parse(idTipoUsuario.ToString()),
                byte.Parse(idDepartmaneto.ToString())

         );
            MessageBox.Show("Gerente Agregado");

        }
    }
}
