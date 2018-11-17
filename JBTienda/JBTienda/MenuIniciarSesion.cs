using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Media;

namespace JBTienda
{
    public partial class MenuIniciarSesion : MaterialSkin.Controls.MaterialForm
    {
        SoundPlayer player = new SoundPlayer();
        public byte idDepa;
        Conexion Conexion = new Conexion();
        public MenuIniciarSesion()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }



        void ConsultarDep(string id)
        {
            dcTiendaDataContext dc = new dcTiendaDataContext();
            var dep = from d in dc.ConsultarDep(id)
                      select d;
            foreach (var n in dep)
            {


                Variables.idDep = byte.Parse(n.idDepartamento.ToString());



            }
        }

        public void login(String v_usuario, String v_contraseña)
        {
            try
            {



                bool bandera = false;
                dcTiendaDataContext dc = new dcTiendaDataContext();

                var log = from l in dc.Logear(v_usuario, v_contraseña)
                          select new { l.nombre, l.idTipoUSuario, l.idUsuario };



                foreach (var u in log)
                {
                    bandera = true;



                    switch (int.Parse(u.idTipoUSuario.ToString()))
                    {

                        case 1:
                            //   MessageBox.Show("Bienvenido,Usted es Administrador.");

                            // Variables.usuario = txtUsuario.Text; 

                            Form Menu = new MenuPrincipalAdmin();
                            Menu.Show();
                            this.Hide();

                            break;
                        case 2:

                            //MessageBox.Show("Bienvenido,Usted es Cliente.");

                            Variables.usuario = txtUsuario.Text;

                            MenuPrincipalCliente ir = new MenuPrincipalCliente();
                            ir.Show();
                            this.Hide();

                            break;
                        case 3:


                            //MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De Computación.");

                            Variables.usuario = txtUsuario.Text;
                            Variables.idDep = idDepa;

                            ConsultarDep(txtUsuario.Text);
                            Form p = new MenuPrincipalGerente();
                            p.Show();
                            this.Hide();





                            break;
                        case 4:
                            //  MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De VideoJuegos.");

                            Variables.usuario = txtUsuario.Text;
                            Variables.idDep = idDepa;
                            ConsultarDep(txtUsuario.Text);
                            Form p1 = new MenuPrincipalGerente();
                            p1.Show();
                            this.Hide();
                            break;
                        case 5:
                            //    MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De Celulares.");

                            Variables.usuario = txtUsuario.Text;
                            Variables.idDep = idDepa;
                            ConsultarDep(txtUsuario.Text);
                            Form p2 = new MenuPrincipalGerente();
                            p2.Show();
                            this.Hide();
                            break;
                        case 6:
                            //      MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De Electrodomesticos.");

                            Variables.usuario = txtUsuario.Text;
                            Variables.idDep = idDepa;
                            ConsultarDep(txtUsuario.Text);
                            Form p3 = new MenuPrincipalGerente();
                            p3.Show();
                            this.Hide();
                            break;
                        case 7:
                            //        MessageBox.Show("Bienvenido,Usted es Jefe de Departamento De Gimnasio.");
                            Variables.usuario = txtUsuario.Text;
                            Variables.idDep = idDepa;
                            ConsultarDep(txtUsuario.Text);
                            Form p4 = new MenuPrincipalGerente();
                            p4.Show();
                            this.Hide();
                            break;



                    }

                }

                if (bandera == false)
                {
                    
                    player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\incorrecto.wav";
                    player.Play();


                    MessageBox.Show("Usuario y contraseña incorrectos");
                    Variables.reintentos++;

                    for (int x = 1; Variables.reintentos <= 3; x++)
                    {

                        MessageBox.Show("Reintento " + Variables.reintentos + " / 3");
                        break;
                    }

                    if (Variables.reintentos == 3)
                    {
                        player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\usuario_bloqueado.wav";
                        player.Play();
                        MessageBox.Show("Usuario Bloqueado, Si no recuerda su contraseña Seleccione la opcion de recuperar Contraseña.");
                        Application.Exit();
                    }
                }


            }
            catch(System.Exception)
            {
                player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\error_en_la_conexion.wav";
                player.Play();
                MessageBox.Show("Error con la conexión, Consulte con su administrador");
                Application.Exit();
            }

        }

    


        private void FormLogin_Load(object sender, EventArgs e)
        {

   
            player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\iniciar_sesion.wav";
            player.Play();

        }

            
        //Metodo que lleva al frame para registrarse

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
           
            RegistrarUsuarios Registro = new RegistrarUsuarios();
            Registro.Show();
            this.Hide();
        }

        //Metodo que al presionar el boton Valida si los datos son correctos

        private void btnIncio_Click(object sender, EventArgs e)
        {
           
                login(txtUsuario.Text, txtContraseña.Text);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
        }

        //Metodo para preguntar si deseas salir de la aplicacion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\cerrar_aplicacion.wav";
            player.Play();
            string message = "Desea cerrar la aplicacion?";
            string caption = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\hasta_luego.wav";
                player.Play();

                MessageBox.Show("Hasta Luego!");
                Application.Exit();

            }

        }

        //Metodo para mostrar/No mostrar contraseña

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (Mostrar.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }

        }


        //Metodo de validaciones del txtUsuario

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            //if (txtUsuario.Text.Trim().Length <= 0)
            //{
            //    MessageBox.Show("El Campo nombre es requerido!", "campo requerido",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
            //    e.Cancel = true;
            //}
            //else
            //{
            //    e.Cancel = false;
            //    txtContraseña.Focus();
            //}

            if (txtUsuario.Text.Trim() == "")
            {
                player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\introduzca_usuario.wav";
                player.Play();
                errorUsuario.SetError(txtUsuario, "Campo Vacio, Introdusca Usuario");
             
               // e.Cancel = true;

            }
            else
            {
                errorUsuario.Clear();
                //e.Cancel = false;
                //txtContraseña.Focus();

            }
        }

        //Metodo para validar que el campo contraseña no este vacio

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            //if (txtContraseña.Text.Trim().Length <= 0)
            //{
            //    MessageBox.Show("El Campo nombre es requerido!", "campo requerido",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
            //    e.Cancel = true;
            //}
            //else
            //{
            //    e.Cancel = false;
            //    btnInicio.Focus();
            //}

            if (txtContraseña.Text.Trim() == "")
            {

                player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\introduzca_contraseña.wav";
                player.Play();
                errorContraseña.SetError(txtContraseña, "Campo Vacio, Introdusca Contraseña");
                //e.Cancel = true;

            }
            else
            {
                errorContraseña.Clear();
                //txtContraseña.Focus();
                //e.Cancel = false;

            }
        }


        //Metodo para ir al frame de  recuperar contraseña

        private void linkRC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContra ir = new RecuperarContra();
            ir.ShowDialog();
            this.Hide();
        }


        private void btnAyuda_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\ayuda.wav";
            player.Play();
            System.Diagnostics.Process ayuda = new System.Diagnostics.Process();
            ayuda.StartInfo.FileName = "C:\\Users\\julii\\Desktop\\ManualUsuario\\ManualAyuda_Login1.pdf";
            ayuda.Start();
            ayuda.Close();

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Application.Exit();
            }
        }

        private void MenuIniciarSesion_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                login(txtUsuario.Text, txtContraseña.Text);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }

            if(e.KeyCode == Keys.F1)
            {
                player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\ayuda.wav";
                player.Play();
                System.Diagnostics.Process ayuda = new System.Diagnostics.Process();
                ayuda.StartInfo.FileName = "C:\\Users\\julii\\Desktop\\ManualUsuario\\ManualAyuda_Login1.pdf";
                ayuda.Start();
                ayuda.Close();
            }

            if (e.KeyCode == Keys.Escape)
            {
                player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\cerrar_aplicacion.wav";
                player.Play();
                string message = "Desea cerrar la aplicacion?";
                string caption = "Salir";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    player.SoundLocation = "C:\\Users\\julii\\Desktop\\AUDIOS\\hasta_luego.wav";
                    player.Play();
                    MessageBox.Show("Hasta Luego!");
                    Application.Exit();

                }
            }

           
           
        }
    }
}
