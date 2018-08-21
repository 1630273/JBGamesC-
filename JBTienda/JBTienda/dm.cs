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
    public partial class dm : UserControl
    {
        public dm()
        {
            InitializeComponent();
        }

        void cargarDescuentos()
        {
            cboDesc.SelectedIndexChanged -= new EventHandler(cboDesc_SelectedIndexChanged);


            dcTiendaDataContext dc = new dcTiendaDataContext();
            var carreras = from c in dc.CargarDescuentos()
                           select new { c.idDescuento, c.descuento };

            cboDesc.DataSource = carreras.ToList();
            cboDesc.ValueMember = "idDescuento";
            cboDesc.DisplayMember = "idDescuento";

            cboDesc.SelectedIndexChanged += new EventHandler(cboDesc_SelectedIndexChanged);
        }

        void cargarProducto(byte idProducto)
        {


            dcTiendaDataContext pro = new dcTiendaDataContext();
            var datosProducto = from con in pro.consultarDatosProductos2(idProducto)
                              select con;

            foreach (var c in datosProducto)
            {

                txtId.Text = c.idProducto.ToString();
                txtNombre.Text = c.nombreProducto;
                txtDescripcion.Text = c.descripcion;
                txtPrecio.Text = c.precio.ToString();
                txtCantidad.Text = c.cantidad.ToString();
                cboDesc.Text = c.idDescuento.ToString();
               // pic1.Image = c.imagen;


            }

        }

        void cargarEquipos()
        {
            lstModificar.SelectedIndexChanged -= new EventHandler(lstModificar_SelectedIndexChanged);

            dcTiendaDataContext dc = new dcTiendaDataContext();

            var torneo = from t in dc.consultarDatosProducto()
                         select new { t.idProducto, t.nombreProducto };



            lstModificar.DataSource = torneo.ToList();
            lstModificar.ValueMember = "idProducto";
            lstModificar.DisplayMember = "nombreProducto";


            lstModificar.SelectedIndexChanged += new EventHandler(lstModificar_SelectedIndexChanged);
        }

      

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pic1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void cboDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Text = cboDesc.SelectedValue.ToString();
        }

        private void dm_Load(object sender, EventArgs e)
        {
            cargarEquipos();
            cargarDescuentos();
        
        }

       

        private void btnModificar_Click(object sender, EventArgs e)
        {

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pic1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            dcTiendaDataContext mod = new dcTiendaDataContext();
            mod.modificarProducto(
                Byte.Parse(txtId.Text),
                txtNombre.Text,
                txtDescripcion.Text,
                int.Parse(txtPrecio.Text),
                byte.Parse(txtCantidad.Text),
                ms.GetBuffer(),
                byte.Parse(cboDesc.Text)
             


         );
            MessageBox.Show("Producto Modificado");
        }

        private void lstModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarProducto(byte.Parse(lstModificar.SelectedValue.ToString()));
        }

        private void lstModificar_Click(object sender, EventArgs e)
        {
            txtId.Text = lstModificar.SelectedValue.ToString();
            txtNombre.Text = lstModificar.SelectedValue.ToString();
            txtDescripcion.Text = lstModificar.SelectedValue.ToString();
            txtPrecio.Text = lstModificar.SelectedValue.ToString();
            txtCantidad.Text = lstModificar.SelectedValue.ToString();
            cboDesc.Text = lstModificar.SelectedValue.ToString();
        }
    }
}
