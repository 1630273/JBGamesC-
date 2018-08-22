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
    public partial class de : UserControl
    {
        public de()
        {
            InitializeComponent();
        }

        void cargarProducto( byte idProducto)
        {
            cboNombre.SelectedIndexChanged -= new EventHandler(cboNombre_SelectedIndexChanged);

            dcTiendaDataContext dc = new dcTiendaDataContext();

            var Jugador = from j in dc.consultarProductos(idProducto)
                          select new { j.Id, j.Nombre };



            cboNombre.DataSource = Jugador.ToList();
            cboNombre.ValueMember = "Id";
            cboNombre.DisplayMember = "Nombre";


            cboNombre.SelectedIndexChanged += new EventHandler(cboNombre_SelectedIndexChanged);
        }

        private void cboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = cboNombre.SelectedValue.ToString();
        }

        private void cboNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dcTiendaDataContext dc = new dcTiendaDataContext();
            dc.eliminarProducto(

                Byte.Parse(txtId.Text)
            

            );
            MessageBox.Show("Producto Eliminado");

        }

        private void de_Load(object sender, EventArgs e)
        {
            cargarProducto(byte.Parse(Variables.idDep.ToString()));
        }
    }
}
