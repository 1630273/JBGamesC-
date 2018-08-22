using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JBTienda
{
   public class UsuarioNeg
    {
        private CapaDeDatos objDatos = new CapaDeDatos();



        public String recuContra(String idUsuario)
        {
            String mensaje;
            mensaje = objDatos.RecuperarContraseña(idUsuario);
            return mensaje;

        }
    }
}
