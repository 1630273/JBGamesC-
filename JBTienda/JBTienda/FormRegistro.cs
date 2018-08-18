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
    public partial class FormRegistro : MaterialSkin.Controls.MaterialForm
    {
        public FormRegistro()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple600, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple100, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }


        void cargarEstados()
        {
            cboEstado.SelectedIndexChanged -= new EventHandler(cboEstado_SelectedIndexChanged);


            //OBJETO DEL TIPO DATA CONTEXT
            dcTiendaDataContext dc = new dcTiendaDataContext();

            //VARIABLE DESCRIPTIVA A LO QUE VOY A TREAER
            var Estado = from es in dc.cargarEstados()
                         select new { es.idEstado, es.desEstado };

            cboEstado.DataSource = Estado.ToList();
            cboEstado.ValueMember = "idEstado";
            cboEstado.DisplayMember = "desEstado";

            cboEstado.SelectedIndexChanged += new EventHandler(cboEstado_SelectedIndexChanged);
        }

        void cargarCiudades(byte idEstado)
        {
            //OBJETO DEL TIPO DATA CONTEXT
            dcTiendaDataContext dc = new dcTiendaDataContext();

            //VARIABLE DESCRIPTIVA A LO QUE VOY A TREAER
            var Ciudad = from ec in dc.cargarCiudades(idEstado)
                         select new { ec.idCiudad, ec.desCiudad };

            cboCiudad.DataSource = Ciudad.ToList();
            cboCiudad.ValueMember = "idCiudad";
            cboCiudad.DisplayMember = "desCiudad";
        }


        private void FormRegistro_Load(object sender, EventArgs e)
        {
            cargarEstados();
            cargarCiudades(byte.Parse(cboEstado.SelectedValue.ToString())); 
        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCiudades(byte.Parse(cboEstado.SelectedValue.ToString()));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            char idSexo = ' ';
            int idTipoUsuario = 2;

            if (rdoHombre.Checked == true)
            {
                idSexo = 'H';
            }
            else if (rdoMujer.Checked == true)
            {
                idSexo = 'M';
            }

                dcTiendaDataContext dc = new dcTiendaDataContext();
                dc.agregarUsuarios(
                    txtNombreUsuario.Text,
                    txtContraseña.Text,
                    txtContraseña2.Text,
                    txtNombre.Text,
                    txtApellidoPaterno.Text,
                    txtApellidoMaterno.Text,
                    idSexo,
                    txtTelefono.Text,
                    txtCorreo.Text,
                    txtDireccion.Text,
                    txtCp.Text,
                    byte.Parse(cboCiudad.SelectedValue.ToString()),
                    byte.Parse(idTipoUsuario.ToString())

             );
                MessageBox.Show("Usuario Agregado");
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormLogin volver = new FormLogin();
            volver.Show();
            this.Hide();
        }
    }
}
