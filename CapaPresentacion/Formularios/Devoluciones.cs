﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Devoluciones : Form
    {
        public Devoluciones()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuVendedor vendedor = new MenuVendedor();
            vendedor.Show();
            this.Hide();
        }
    }
}
