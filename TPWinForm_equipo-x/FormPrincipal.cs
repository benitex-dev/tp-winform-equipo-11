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
using TPWinForm_equipo_11B;

namespace TPWinForm_equipo_11
{
    public partial class VentanaPrincipal : Form
    {

        private List<Articulo> listaArticulos;
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
            
            comboBoxCampo.Items.Add("Código");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Descripción");
            comboBoxCampo.Items.Add("Precio");
        }
        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();


            try
            {
                listaArticulos = articuloNegocio.listar();
                //listamos los articulos en nuestro data grid view
                dgvCatalogo.DataSource = articuloNegocio.listar();
                ocultarColumnas();


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

        private void btnDetalle_Click(object sender, EventArgs e)
        {

            if (dgvCatalogo.CurrentRow == null || dgvCatalogo.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un artículo para ver detalle");
                return;
            }

            try
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;

                FormDetalle formDetalle = new FormDetalle(seleccionado);

                formDetalle.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Acceso inválido" + ex.ToString());
            }
            
            
        }

        private void eliminar()
        {
            Articulo seleccionado;
            ArticuloNegocio articulo = new ArticuloNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad queres Eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;

                    articulo.eliminarArticulo(seleccionado.Id);

                    cargar();
                }
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCatalogo.CurrentRow == null || dgvCatalogo.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("Seleccione un artículo");
                    return;
                }
            try
            {
                   eliminar();     
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxFiltro.Text;

            if(filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.CodArticulo.ToUpper().Contains(filtro.ToUpper())|| x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = listaFiltrada;
            ocultarColumnas();
        }



        private void ocultarColumnas()
        {
            //escondemos la columna imagen ya que la url de la misma no es importante para el usuario
            dgvCatalogo.Columns["Imagen"].Visible = false;
            // escondemos la columna id ya que la misma solo es importante para el desarrollador
            dgvCatalogo.Columns["Id"].Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxFiltro.Text = "";

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCatalogo.CurrentRow == null || dgvCatalogo.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un artículo para modificar");
                return;
            }

            try
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;

                FormAltaArticulo modificarArticulo = new FormAltaArticulo(seleccionado);

                modificarArticulo.ShowDialog();
                cargar();
            }
           
            catch(Exception ex)
            {
                MessageBox.Show("Modificación no permitida" + ex.ToString());
            }
           

            
        }
        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string opcion = comboBoxCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {   
                //validacion para filtro avanzado
                if (validarFiltro()) return;
                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvCatalogo.DataSource = articuloNegocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private bool validarFiltro()
        {
            if (comboBoxCampo.SelectedIndex < 0)
            {

                MessageBox.Show("Por favor seleccione el campo para filtrar");
                return true;
            }
            if (comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio para filtrar");
                return true;
            }
            if (comboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para númericos");
                    return true;
                }

                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo numeros para filtrar por campo numerico");
                    return true;
                }
            }

            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {

                if (!(char.IsNumber(caracter)))
                { return false; }

            }
            return true;
        }
        // boton agregar marcas
        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();

            marcas.ShowDialog();
            cargar();
        }
    }
}
