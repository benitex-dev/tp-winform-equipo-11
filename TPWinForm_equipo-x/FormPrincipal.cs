﻿using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_11
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltaArticulo altaArticulo = new FormAltaArticulo();
            
            altaArticulo.Show();
            
        }

        

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            //ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            //dgvCatalogo.DataSource = articuloNegocio.listar();
        }
    }
}
