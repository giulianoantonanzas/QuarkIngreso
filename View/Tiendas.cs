﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class Tiendas : Form
    {
        public Tiendas()
        {
            InitializeComponent();
        }

        private void nuevaTienda_Click(object sender, EventArgs e)
        {
            new NuevaTienda().Show();
        }
    }
}
