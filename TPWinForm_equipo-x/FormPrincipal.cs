using dominio;
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
            cargar();
        }

        

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
           
        }
        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                //listamos los articulos en nuestro data grid view
                dgvCatalogo.DataSource = articuloNegocio.listar();
                //escondemos la columna imagen ya que la url de la misma no es importante para el usuario
                dgvCatalogo.Columns["Imagen"].Visible = false;
                // escondemos la columna id ya que la misma solo es importante para el desarrollador
                dgvCatalogo.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxImagen.Load("https://cdn-icons-png.flaticon.com/512/813/813728.png"); //se carga una imagen por defecto
            }
        }

        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCatalogo.CurrentRow != null)
            {

                Articulo seleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;

                ImagenNegocio negocio = new ImagenNegocio();
                List<Imagen> imagenes = negocio.listarImagenesArticulo(seleccionado.Id);

                if (imagenes.Count > 0 && imagenes != null) cargarImagen(imagenes[0].URL); //selecciona la primera imagen de la lista por lo tanto es la imagen principal del articulo
                     
            }
        }
    }
}
