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
    public partial class FormComprar : MaterialSkin.Controls.MaterialForm
    {

        public FormComprar()
        {

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }


        void cargarinfo(byte info)
        {
            dcTiendaDataContext pro = new dcTiendaDataContext();
            var datosProducto = from con in pro.consultarDatosComprar(info)
                                select con;

            foreach (var c in datosProducto)
            {


                txtNombre.Text = c.Nombre;
                txtDescripcion.Text = c.Descripcion;
                txtPrecio.Text = c.Precio.ToString();
                txtDes.Text = c.Descuento.ToString();


                if (txtDes.Text == "25%")
                {
                    var pre = double.Parse(txtPrecio.Text);

                    Variables.Np = pre * 0.25;
                }
                else if (txtDes.Text == "50%")
                {
                    var pre = double.Parse(txtPrecio.Text);

                    Variables.Np = pre * 0.50;

                }
                else if (txtDes.Text == "75%")
                {
                    var pre = double.Parse(txtPrecio.Text);

                    Variables.Np = pre * 0.75;

                }
                else if (txtDes.Text == "0%")
                {
                    Variables.Np = double.Parse(txtPrecio.Text);


                }

                txtnp.Text = Variables.Np.ToString();

                txtCliente.Text = Variables.usuario;




            }
        }


        private void listarProductos()
        {
            try
            {


                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("SELECT imagen FROM Producto WHERE idProducto = @idPro", "Data Source=LAPTOP-LN2ROB9J\\SQLEXPRESS01;Initial Catalog=Tienda;Integrated Security=True");

                da.SelectCommand.Parameters.Add("@idPro", System.Data.SqlDbType.TinyInt);
                da.SelectCommand.Parameters["@idPro"].Value = Variables.idProd;

                // Se recuperan los datos
                da.Fill(ds, "Producto");


                // El campo productImage primero se almacena en un buffer
                byte[] imageBuffer = (byte[])ds.Tables["Producto"].Rows[0]["imagen"];
                // Se crea un MemoryStream a partir de ese buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                // Se utiliza el MemoryStream para extraer la imagen
                pic1.Image = Image.FromStream(ms);

            }
            catch (System.Exception)
            {
                MessageBox.Show("Problema con el servidor.");

                Application.Exit();
            }

        }



        private void FormComprar_Load(object sender, EventArgs e)
        {

            cargarinfo(Variables.idProd);
            listarProductos();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (cantidad.Value > 1)
            {

                string message = "Desea Salir Sin Guardar?";
                string caption = "Salir";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Form A = new FormComprar();
                    this.Hide();

                }

            }
            else
            {
                string message = "Desea Salir?";
                string caption = "Salir";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Form A = new FormComprar();
                    this.Hide();

                }

            }

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            var p = double.Parse(txtnp.Text);

            var can = int.Parse(cantidad.Value.ToString());

            Variables.tc = p * can;
            txtTo.Text = Variables.tc.ToString();

            

            string message = "Desea Confirmar Su Compra ? ";
            string caption = "Comprar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {


                
                dcTiendaDataContext dc = new dcTiendaDataContext();
                dc.ConsultarCompras(
                    txtNombre.Text,
                    txtDescripcion.Text,
                   int.Parse(txtnp.Text.ToString()),
                     int.Parse(cantidad.Value.ToString()),
                    int.Parse(txtTo.Text.ToString()),
                    txtCliente.Text


             );

                MessageBox.Show("Producto Agregado al Carrito");

            }
         

        }

        private void txtnp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormComprar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {


                if (cantidad.Value > 1)
                {

                    string message = "Desea Salir Sin Guardar?";
                    string caption = "Salir";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Form A = new FormComprar();
                        this.Hide();

                    }

                }
                else
                {
                    string message = "Desea Salir?";
                    string caption = "Salir";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Form A = new FormComprar();
                        this.Hide();

                    }

                }
            }

            if(e.KeyCode == Keys.Enter)
            {
                string message = "Desea Confirmar Su Compra?";
                string caption = "Comprar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    dcTiendaDataContext dc = new dcTiendaDataContext();
                    dc.ConsultarCompras(
                        txtNombre.Text,
                        txtDescripcion.Text,
                       int.Parse(txtnp.Text.ToString()),
                         int.Parse(cantidad.Value.ToString()),
                        int.Parse(txtTo.Text.ToString()),
                        txtCliente.Text


                 );

                    MessageBox.Show("Producto Agregado al Carrito");

                }

            }
        }
    }
}
