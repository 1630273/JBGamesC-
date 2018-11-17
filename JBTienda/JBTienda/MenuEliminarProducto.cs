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
    public partial class MenuEliminarProducto : UserControl
    {
        public MenuEliminarProducto()
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Estas seguro que desea eliminar el producto?";
            string caption = "Eliminar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                dcTiendaDataContext dc = new dcTiendaDataContext();
                dc.eliminarProducto(

                    Byte.Parse(txtId.Text)


                );
                MessageBox.Show("Producto Eliminado");

            }

        }

        private void de_Load(object sender, EventArgs e)
        {
            cargarProducto(byte.Parse(Variables.idDep.ToString()));
        }

        private void cboNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string message = "Estas seguro que desea eliminar?";
                string caption = "Eliminar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    dcTiendaDataContext dc = new dcTiendaDataContext();
                    dc.eliminarProducto(

                        Byte.Parse(txtId.Text)


                    );
                    MessageBox.Show("Producto Eliminado");
                   // cboNombre.Items.Remove(cboNombre.SelectedItem);

                }
            }
        }
    }
}
