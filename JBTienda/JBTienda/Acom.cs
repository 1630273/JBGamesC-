using System;
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
    public partial class Acom : UserControl
    {
        public Acom()
        {
            InitializeComponent();
        }

        private void Acom_Load(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

    

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            char idSexo = ' ';
            int idTipoUsuario = 3;
            int idDepartmaneto = 1;

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
