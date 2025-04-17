using negocio;
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
            
            altaArticulo.ShowDialog();
            
        }

        

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            //listamos los articulos en nuestro data grid view
            dgvCatalogo.DataSource = articuloNegocio.listar();
            //escondemos la columna imagen ya que la url de la misma no es importante para el usuario
            dgvCatalogo.Columns["Imagen"].Visible = false;
            // escondemos la columna id ya que la misma solo es importante para el desarrollador
            dgvCatalogo.Columns["Id"].Visible = false;
        }
    }
}
