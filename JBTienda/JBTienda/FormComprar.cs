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
                     var pre =double.Parse(txtPrecio.Text);

                    Variables.Np = pre * 0.25;   
                }else if(txtDes.Text == "50%")
                {
                   var pre = double.Parse(txtPrecio.Text);

                    Variables.Np = pre * 0.50;

                }else if(txtDes.Text == "75%")
                {
                    var pre = double.Parse(txtPrecio.Text);

                    Variables.Np = pre * 0.75;

                }
                else if (txtDes.Text == "0%")
                {
                    Variables.Np = double.Parse(txtPrecio.Text);


                }

                txtnp.Text = Variables.Np.ToString();



            }
        }

        
                
        private void listarProductos()
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("SELECT imagen FROM Producto WHERE idProducto = @idPro", "Data Source=DESKTOP-4UDBD8N\\SQLEXPRESS;Initial Catalog=Tienda;Integrated Security=True");

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



        private void FormComprar_Load(object sender, EventArgs e)
        {
            cargarinfo(Variables.idProd);

            listarProductos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMCliente p = new FormMCliente();
            p.Show();
            this.Hide();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            dcTiendaDataContext dc = new dcTiendaDataContext();
            dc.ConsultarCompras(
                txtNombre.Text,
                txtDescripcion.Text,
               int.Parse( txtnp.Text.ToString()),
                 int.Parse(cantidad.Value.ToString())
      
         );
            
            MessageBox.Show("Producto Agregado al Carrito");

            FormMCliente ir = new FormMCliente();
            ir.Show();
            this.Hide();
         




        }
    }



}
