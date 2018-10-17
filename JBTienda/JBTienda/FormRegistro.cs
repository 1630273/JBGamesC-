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

        private bool ok;

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

     
        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCiudades(byte.Parse(cboEstado.SelectedValue.ToString()));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CancelEventArgs err = new CancelEventArgs();

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


            //if (rdoHombre.Checked == false || rdoMujer.Checked == false)
            //{
            //    MessageBox.Show("Seleccione una opcion");
            //    errorSexo.SetError(rdoMujer, "Tiene que seleccionar una opcion.");
            //    err.Cancel = true;
            //}
           
        

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

        private void txtNombreUsuario_Validating(object sender, CancelEventArgs e)
        {
           
            if (txtNombreUsuario.Text.Trim() == "")
            {
             
                errorUsuario.SetError(txtNombreUsuario, "Campo Vacio, Introdusca Usuario");
                e.Cancel = true;
               
            }
            else
            {

                errorUsuario.Clear();
                e.Cancel = false;
                txtContraseña.Focus();
              
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (txtContraseña.Text.Trim() == "")
            {
              
                errorContraseña.SetError(txtContraseña, "Campo Vacio, Introdusca Contraseña");
                e.Cancel = true;
              
            }
            else
            {
             
                errorContraseña.Clear();
                e.Cancel = false;
                txtContraseña2.Focus();
            }
        }

        private void txtContraseña2_Validating(object sender, CancelEventArgs e)
        {

            if (txtContraseña.Text != txtContraseña2.Text)
            {
               
                errorContraseña2.SetError(txtContraseña2, "Las contraseñas no son Iguales.");
                e.Cancel = true;
            }

            else
            {
               
                errorContraseña2.Clear();
                e.Cancel = false;
                txtNombre.Focus();

            }

           
        }


       

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

            if (txtNombre.Text.Trim() == "")
            {
                
                errorNombre.SetError(txtNombre, "Campo Vacio, Ingrese Nombre.");
                e.Cancel = true;
            }

            else
            {
              
                errorNombre.Clear();
                e.Cancel = false;
                txtApellidoPaterno.Focus();

            }

        }

      

        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoPaterno.Text.Trim() == "")
            {

                errorAp.SetError(txtApellidoPaterno, "Campo Vacio, Ingrese Apellido Paterno.");
                e.Cancel = true;
            }

            else
            {

                errorAp.Clear();
                e.Cancel = false;
                txtApellidoMaterno.Focus();

            }

        }


      

        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoMaterno.Text.Trim() == "")
            {

                errorAm.SetError(txtApellidoMaterno, "Campo Vacio, Ingrese Apellido Materno.");
                e.Cancel = true;
            }

            else
            {

                errorAm.Clear();
                e.Cancel = false;
                txtCorreo.Focus();

            }

        }


     

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {

                errorCorreo.SetError(txtCorreo, "Campo Vacio, Ingrese Correo.");
                e.Cancel = true;
            }

            else
            {

                errorCorreo.Clear();
                e.Cancel = false;
                txtDireccion.Focus();

            }

        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Trim() == "")
            {

                errorDireccion.SetError(txtDireccion, "Campo Vacio, Ingrese Direccion.");
                e.Cancel = true;
            }

            else
            {

                errorDireccion.Clear();
                e.Cancel = false;
                txtCp.Focus();

            }
        }

        private void txtCp_Validating(object sender, CancelEventArgs e)
        {
            if (txtCp.Text.Trim() == "")
            {

                errorCp.SetError(txtCp, "Campo Vacio, Ingrese Codigo Postal.");
                e.Cancel = true;
            }

            else
            {

                errorCp.Clear();
                e.Cancel = false;
                txtTelefono.Focus();

            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {

                errorTelefono.SetError(txtTelefono, "Campo Vacio, Ingrese Telefono.");
                e.Cancel = true;
            }

            else
            {

                errorTelefono.Clear();
                e.Cancel = false;
               
               

            }

        }


        private void rdoMujer_Validating(object sender, CancelEventArgs e)
        {
          

        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

    }
}
