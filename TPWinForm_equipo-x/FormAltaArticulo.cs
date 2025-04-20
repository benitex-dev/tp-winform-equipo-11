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
        private Articulo articulo = null;

        public FormAltaArticulo()
        {
            InitializeComponent();
        }

        public FormAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
           lblTitulo.Text = "Modificar Articulo";
            Text = "Modificar Articulo";
            btnCrearArticulo.Text = "Modificar";
        }

        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {   
           // Articulo articulo = new Articulo();
            Imagen imagen = new Imagen();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();

                }
                    

                articulo.CodArticulo = txtCodArt.Text;
                articulo.Nombre = txtNombreArt.Text;
                articulo.Descripcion = txtDescripArt.Text;
                articulo.Precio =decimal.Parse(txtPrecio.Text) ;
                articulo.Marca =(Marca) cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria) cmbCategoria.SelectedItem;
                
                imagen.URL = txtImg.Text;
                articulo.Imagen = imagen;


                if(articulo.Id != 0)
                {
                    imagen.IdArticulo=articulo.Id;
                    articuloNegocio.modificar(articulo);
                    imagenNegocio.modificarImagenArticulo(imagen);
                    articuloNegocio.listar();
                    MessageBox.Show("Articulo modificado exitosamente");
                }
                else
                {
                    articuloNegocio.agregarArticulo(articulo);
                    articuloNegocio.listar();

                    int idUltimoArticuloInsertado = 0;
                    idUltimoArticuloInsertado = articuloNegocio.getUltimoRegistroInsertado();

                    imagen.IdArticulo = idUltimoArticuloInsertado;
                    imagenNegocio.agregarImagenArticulo(imagen);

                    MessageBox.Show("Articulo agregado exitosamente");
                }
                
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
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> imagenes = new List<Imagen>(); 
            try
            {
                cmbCategoria.DataSource = categoriaNegocio.listar();
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";
                cmbMarca.DataSource = marcaNegocio.listar();
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtNombreArt.Text = articulo.Nombre;
                    txtCodArt.Text = articulo.CodArticulo;
                    txtDescripArt.Text = articulo.Descripcion;
                    
                    //if(articulo.Imagen != null && articulo.Imagen.URL != null)
                    //{
                        int idArticulo = articulo.Id;
                        imagenes = imagenNegocio.listarImagenesArticulo(idArticulo);
                         txtImg.Text = imagenes[0].URL.ToString();
                         cargarImagen(txtImg.Text);
                    //}
                  
                    txtPrecio.Text = articulo.Precio.ToString();

                    cmbCategoria.SelectedValue = articulo.Categoria.Id;
                    cmbMarca.SelectedValue = articulo.Marca.Id;


                }
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
