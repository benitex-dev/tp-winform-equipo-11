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
    public partial class FormAltaArticulo : Form
    {
        public FormAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {   
            Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                articulo.CodArticulo = txtCodArt.Text;
                articulo.Nombre = txtNombreArt.Text;
                articulo.Descripcion = txtDescripArt.Text;
                articulo.Precio =decimal.Parse(txtPrecio.Text) ;
                articulo.Marca =(Marca) cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria) cmbCategoria.SelectedItem;

                articuloNegocio.agregarArticulo(articulo);
                MessageBox.Show("Articulo agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cmbCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
