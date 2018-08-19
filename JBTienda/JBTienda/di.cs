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
    public partial class di : UserControl
    {
        public di()
        {
            InitializeComponent();
        }

        void cargarProductos(byte id)
        {
            dcTiendaDataContext st = new dcTiendaDataContext();

            var r = from con in st.consultarProductos(id)
                    select con;

            foreach (var n in r)
            {

                dtai.Rows.Add(n.idProducto, n.nombreDepa, n.nombreProducto,n.descripcion,n.precio,n.cantidad,n.imagen
                    );
            }
        }

        private void dtai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void di_Load(object sender, EventArgs e)
        {
           cargarProductos(Variables.idDep);
        }
    }
}
