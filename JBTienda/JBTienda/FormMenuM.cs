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
    public partial class FormMenuM : MaterialSkin.Controls.MaterialForm
    {
        public FormMenuM()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);
        }

        private void FormMenuM_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form A = new FormLoginA();
            A.Show();
            this.Hide();
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            Form D = new FormLoginD();
            D.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form A = new FormPortada();
            A.Show();
            this.Hide();

        }
    }
}
