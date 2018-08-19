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
    public partial class Ainicio : UserControl
    {
        public Ainicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void CargarEmpleados()
        {
            dcTiendaDataContext st = new dcTiendaDataContext();

            var r = from con in st.consultarGerentes()
                    select con;

            foreach (var n in r)
            {

                dtai.Rows.Add(n.nombredepa,  n.NombreCompleto, n.idGerente
                    );
            }
        }
        private void Ainicio_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
    }
}
