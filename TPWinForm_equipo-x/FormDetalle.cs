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
    public partial class FormDetalle : Form
    {

        private Articulo articulo = null;
        private List<Imagen> imagenes = new List<Imagen>();
        private int siguiente = 0;
        private int contadorImagen = 1;
        public FormDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {
           
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            lblCodigo.Text = articulo.CodArticulo;
            lblDescripcion.Text = articulo.Descripcion;
            lblNombre.Text = articulo.Nombre;
            lblPrecio.Text = "$" + articulo.Precio.ToString();
            lblCategoria.Text = articulo.Categoria.ToString();
            lblMarca.Text = articulo.Marca.ToString();

            imagenes = imagenNegocio.listarImagenesArticulo(articulo.Id);

            if (imagenes.Count > 0 && imagenes != null)
            {
                cargarImagen(imagenes[siguiente].URL);
                btnNext.Visible = imagenes.Count > 1;
                lblImagen.Text = "Imagen " + contadorImagen + " de " + imagenes.Count;
            }
            else
            {
                pboxDetalle.Load("https://cdn-icons-png.flaticon.com/512/813/813728.png"); //se carga una imagen por defecto
                btnNext.Visible = false;
                lblImagen.Text = "Articulo sin imagen ";
            }        

            btnPrevious.Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxDetalle.Load("https://cdn-icons-png.flaticon.com/512/813/813728.png"); //se carga una imagen por defecto
            }
        }

        
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (siguiente < imagenes.Count - 1)
            {
                siguiente++;
                contadorImagen= 1 + siguiente;
                cargarImagen(imagenes[siguiente].URL);
                btnPrevious.Visible = true;
                btnNext.Visible = siguiente < imagenes.Count - 1;
                lblImagen.Text = "Imagen " + contadorImagen + " de " + imagenes.Count;
            }              
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (siguiente >= 1)
            {
                siguiente--;
                contadorImagen = 1 + siguiente;
                cargarImagen(imagenes[siguiente].URL);
                btnNext.Visible = true;
                btnPrevious.Visible = siguiente >= 1;
                lblImagen.Text = "Imagen " + contadorImagen + " de " + imagenes.Count;
            }
        
        }
    }
}
