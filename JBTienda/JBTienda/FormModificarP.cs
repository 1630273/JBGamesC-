﻿using System;
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
    public partial class FormModificarP : MaterialSkin.Controls.MaterialForm
    {
        public FormModificarP()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Purple800, MaterialSkin.Accent.Purple700, MaterialSkin.TextShade.WHITE);

        }

        private void FormModificarP_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form p = new FormMenuJ();
            p.Show();
            this.Hide();
        }
    }
}