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
            Imagen imagen = new Imagen();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                articulo.CodArticulo = txtCodArt.Text;
                articulo.Nombre = txtNombreArt.Text;
                articulo.Descripcion = txtDescripArt.Text;
                articulo.Precio =decimal.Parse(txtPrecio.Text) ;
                articulo.Marca =(Marca) cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria) cmbCategoria.SelectedItem;
                
                imagen.URL = txtImg.Text;
                articulo.Imagen = imagen;

                articuloNegocio.agregarArticulo(articulo);
                articuloNegocio.listar();
                
                int idUltimoArticuloInsertado = 0;
                idUltimoArticuloInsertado = articuloNegocio.getUltimoRegistroInsertado();

                imagen.IdArticulo = idUltimoArticuloInsertado;
                imagenNegocio.agregarImagenArticulo(imagen);

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
            MarcaNegocio marcaNegocio = new MarcaNegocio(); 
            try
            {
                cmbCategoria.DataSource = categoriaNegocio.listar();
                cmbMarca.DataSource = marcaNegocio.listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtImg_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImg.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxArticulo.Load("https://cdn-icons-png.flaticon.com/512/813/813728.png"); //se carga una imagen por defecto
            }
        }
    }
}
