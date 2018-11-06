using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBTienda
{
    public partial class MenuInicioAdmin : UserControl
    {
        public MenuInicioAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void CargarEmpleados()
        {
            dcTiendaDataContext st = new dcTiendaDataContext();

            var r = from con in st.consultarGerentes()
                    select con;

            foreach (var n in r)
            {

                dtai.Rows.Add(n.nombredepa,  n.NombreCompleto, n.idUsuario
                    );
            }
        }
        private void Ainicio_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
    }
}
