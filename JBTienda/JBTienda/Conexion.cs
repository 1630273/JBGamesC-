using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace JBTienda
{
    public class Conexion
    {
        private SqlConnection Con = new SqlConnection("Data Source=DESKTOP-8C15TUM;Initial Catalog=Tienda;Integrated Security=True");
        public SqlConnection AbrirConexion()
        {
            if (Con.State == System.Data.ConnectionState.Closed)
                Con.Open();
            return Con;
        }

        public SqlConnection CerrarConexion()
        {
            if (Con.State == System.Data.ConnectionState.Open)
                Con.Close();
            return Con;
        }







    }
}
