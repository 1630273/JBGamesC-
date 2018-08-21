using System;
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
    public partial class FormModificarP : MaterialSkin.Controls.MaterialForm
    {
        public FormModificarP()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }

        private void FormModificarP_Load(object sender, EventArgs e)
        {
            cargarProducto(Variables.idProd);
            cargarDescuentos();
        }

        void cargarDescuentos()
        {
            


            dcTiendaDataContext dc = new dcTiendaDataContext();
            var carreras = from c in dc.CargarDescuentos()
                           select new { c.idDescuento, c.descuento };

            cboDesc.DataSource = carreras.ToList();
            cboDesc.ValueMember = "idDescuento";
            cboDesc.DisplayMember = "Descuento";

       
        }

        void cargarProducto(int idProducto)
        {


            dcTiendaDataContext pro = new dcTiendaDataContext();
            var datosProducto = from con in pro.consultarDatosProductos2(idProducto)
                                select con;

            foreach (var c in datosProducto)
            {

                txtNombre.Text = c.nombreProducto;
                txtDescripcion.Text = c.descripcion;
                txtPrecio.Text = c.precio.ToString();
                txtCantidad.Text = c.cantidad.ToString();
                cboDesc.Text = c.idDescuento.ToString();
                //pic1.Image = c.imagen;


            }
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



        private void button2_Click(object sender, EventArgs e)
        {
            Form p = new FormMenuJ();
            p.Show();
            this.Hide();
        }
    }
}
