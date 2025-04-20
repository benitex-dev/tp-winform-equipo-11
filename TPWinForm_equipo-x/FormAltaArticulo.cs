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
            lblImgNueva.Visible = true;
            txtImgNueva.Visible = true;
        }

        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {   
           // Articulo articulo = new Articulo();
            Imagen imagen = new Imagen();

            List<Imagen> imagenes = new List<Imagen>();

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

                if (!(soloNumeros(txtPrecio.Text))) return;
               

                articulo.Precio =decimal.Parse(txtPrecio.Text) ;
                articulo.Marca =(Marca) cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria) cmbCategoria.SelectedItem;
                
                imagen.URL = txtImg.Text;
                imagen.IdArticulo = articulo.Id;
                articulo.Imagen = imagen;

                if (validarCampos()) return;

                if (articulo.Id != 0)
                {

                    imagenes = imagenNegocio.listarImagenesArticulo(articulo.Id);
                    if (imagenes.Count > 0 && imagenes != null)
                    {
                        imagen.Id = imagenes[0].Id;
                        imagenNegocio.modificarImagenArticulo(imagen);//modifica la primer imagen
                    }
                    else
                    {
                        imagenNegocio.agregarImagenArticulo(imagen);// crea una nueva imagen si no tiene ninguna
                    }
                    articuloNegocio.modificar(articulo);
                    

                    if (!string.IsNullOrWhiteSpace(txtImgNueva.Text))
                    {
                        Imagen imagenNueva = new Imagen();
                        imagenNueva.IdArticulo = articulo.Id;
                        imagenNueva.URL = txtImgNueva.Text;
                        imagenNegocio.agregarImagenArticulo(imagenNueva);//agrega una nueva imagen
                    }

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
                    

                    
                    int idArticulo = articulo.Id;
                    imagenes = imagenNegocio.listarImagenesArticulo(idArticulo);
                    if (imagenes.Count > 0 && imagenes != null)
                    {
                        txtImg.Text = imagenes[0].URL.ToString();
                        cargarImagen(txtImg.Text);
                    }
                    else
                    {
                        cargarImagen("https://cdn-icons-png.flaticon.com/512/813/813728.png"); //se carga una imagen por defecto
                        
                    }



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

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreArt.Text) && string.IsNullOrEmpty(txtCodArt.Text) && string.IsNullOrEmpty(txtDescripArt.Text))
            {
                MessageBox.Show("Debes completar los campos obligatorios");
                return true;
            }
            if (string.IsNullOrEmpty(txtNombreArt.Text) || string.IsNullOrWhiteSpace(txtNombreArt.Text))
            {
                MessageBox.Show("Debes completar el campo de Nombre");
                return true;
            }
            if (string.IsNullOrEmpty(txtCodArt.Text) || string.IsNullOrWhiteSpace(txtCodArt.Text))
            {
                MessageBox.Show("Debes completar el campo de Codigo");
                return true;
            }
            if(string.IsNullOrEmpty(txtDescripArt.Text) || string.IsNullOrWhiteSpace(txtDescripArt.Text))
            {
                MessageBox.Show("Debes completar el campo de Descripcion");
                return true;
            }                      
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {                
                if (!(char.IsDigit(caracter)))
                {
                    MessageBox.Show("Solo números por favor para indicar el precio...");
                    return false;
                }
                    
            }
            if (string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Debe completar el campo de precio...");
                return false;
            }
            return true;
        }
    }
}
