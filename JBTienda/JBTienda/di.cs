﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JBTienda
{
    public partial class di : UserControl
    {
        public di()
        {
            InitializeComponent();
        }

        public void listarProductos(DataGridView data)
        {
             SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-8C15TUM;Initial Catalog=Tienda;Integrated Security=True");
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            conn.Open();

            SqlCommand comando = new SqlCommand("consultarProductos", conn);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@idDepartamento", SqlDbType.Int).Value =  Variables.idDep;
            comando.Connection = conn;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
         

            conn.Close();
        }


      

        private void dtai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void di_Load(object sender, EventArgs e)
        { 
            listarProductos(dtai);
        }

       
    }
}
