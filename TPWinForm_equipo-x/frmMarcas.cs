using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_11B
{
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarcas; 
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void cargarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                listaMarcas = negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
                ocultarColumnas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ocultarColumnas()
        {
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            txtMarcaNueva.Visible = true;
            btnMarcaNueva.Visible = true;
        }

        private void btnMarcaNueva_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            if(txtMarcaNueva.Text == null)
            {
                MessageBox.Show("Ingresar Marca");
                return;
            }

            try
            {
                Marca marca = new Marca();
                marca.Descripcion = txtMarcaNueva.Text;
                negocio.agregarMarca(marca);
                MessageBox.Show("Marca agregada exitosamente");
                cargarMarcas();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se puede agregar la Marca." + ex.ToString());
            }
           
        }


        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            txtMarcaModificar.Visible = true;
            btnMarcaModificarAceptar.Visible = true;
            if (dgvMarcas.CurrentRow == null || dgvMarcas.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un ítem para modificar");
                return;
            }

            try
            {
                Marca seleccionada = new Marca();
                seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                txtMarcaModificar.Text = seleccionada.Descripcion;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMarcaModificarAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio negocio = new MarcaNegocio();
                Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                seleccionada.Descripcion = txtMarcaModificar.Text;
                negocio.modificarMarca(seleccionada);
                cargarMarcas();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo modificar." + ex.ToString());
            }
         
        }

        private void btnVolverMarcas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null || dgvMarcas.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un ítem");
                return;
            }
            try
            {
                eliminarMarca();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       private void eliminarMarca()
        {
            Marca seleccionada;
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad queres Eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                    negocio.eliminarMarca(seleccionada.Id);

                    cargarMarcas();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
    }

