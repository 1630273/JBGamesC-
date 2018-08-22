using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;

namespace JBTienda
{
    public class CapaDeDatos
    {
        private Conexion Conexion = new Conexion();
        private SqlDataReader leer;
        private String correo, nombreUsuario, contraseña;
        private String mensaje;
        private SqlCommand comandito = new SqlCommand();


        public String RecuperarContraseña(String idUsuario)
        {
            comandito.Connection = Conexion.AbrirConexion();
            comandito.CommandText = ("SELECT * FROM Usuario WHERE idUsuario = "+idUsuario);
            leer = comandito.ExecuteReader();

            if(leer.Read() == true)
            {
                correo = leer["correo"].ToString();
                nombreUsuario = leer["nombre"].ToString() + "," + leer["apellidoPaterno"].ToString();
                contraseña = leer["contraseña"].ToString();

                enviarEmail();
                mensaje = "Estimado" + nombreUsuario + ", Se le ha enviado a su correo:" + correo + "Verifique su bandeja de entrada";
                leer.Close();
            }
            else
            {
                mensaje = "No existen datos";
            }
            return mensaje;
        }

        public void enviarEmail()
        {

            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("juliiodaniiel98@gmail.com");
            Correo.To.Add(correo);
            Correo.Subject = ("RECUPERAR CONTRASEÑA.");
            Correo.Body = "HOLA" + nombreUsuario + "Usted solicito Recuperar la contraseña\n Su contraseña es: " + contraseña;
            Correo.Priority = MailPriority.Normal;

            SmtpClient ServerMail = new SmtpClient();
            ServerMail.Credentials = new NetworkCredential("juliiodaniiel98@gmail.com", "@admin123");
            ServerMail.Host = "smtp.gmail.com";
            ServerMail.Port = 587;
            ServerMail.EnableSsl = true;
            try
            {
                ServerMail.Send(Correo);
            }
            catch(Exception ex)
            {

            }
            Correo.Dispose();
        

        }


    }
}
