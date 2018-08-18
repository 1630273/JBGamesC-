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
    public partial class FormPortada : MaterialSkin.Controls.MaterialForm
    {
        public FormPortada()
        {
            InitializeComponent();
        }

        private void FormPortada_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form B = new FormMenuM();
            B.Show();
            this.Hide();
        }

        private void btnClliente_Click(object sender, EventArgs e)
        {
            Form Log = new FormLogin();
            Log.Show();
            this.Hide();
        }
    }
}
