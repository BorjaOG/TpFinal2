using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Service;
using WindowsFormsApp1;

namespace Service
{
    public partial class frmArticulos : Form
    {

        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }


        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cbcampo.Items.Add("Nombre");
            cbcampo.Items.Add("Codigo");
            cbcampo.Items.Add("Precio");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
            }

        }

        private void cargar()
        {

            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                CargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbArticulo.Load("https://worldwellnessgroup.org.au/wp-content/uploads/2020/07/placeholder.png");
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btneliminarf_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {

                DialogResult respuesta = MessageBox.Show("seguro quieres eliminar este articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }



        private void tbfiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbfiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cbcampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbcampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbcriterio.Items.Clear();
                cbcriterio.Items.Add("Mayor a");
                cbcriterio.Items.Add("Menor a");
                cbcriterio.Items.Add("Igual a");
            }

            else
            {
                cbcriterio.Items.Clear();
                cbcriterio.Items.Add("Comienza con");
                cbcriterio.Items.Add("Termina con");
                cbcriterio.Items.Add("Contiene");
            }
        }


        private bool validarFiltro()
        {
            if (cbcampo.SelectedIndex < 0)
            {
                MessageBox.Show("Elija un campo para filtrar, por favor.");
                return true;
            }
            if (cbcriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Elija el criterio para filtrar, por favor.");
                return true;
            }
            if (cbcampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(tbfilter.Text))
                {
                    MessageBox.Show("escriba algo en la caja del filtro, por favor.");
                    return true;
                }
                if (!(soloNumeros(tbfilter.Text)))
                {
                    MessageBox.Show("Introduzca solo numeros para filtrar por Precio, por favor.");
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
                    return false;
            }

            return true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cbcampo.SelectedItem.ToString();
                string criterio = cbcriterio.SelectedItem.ToString();
                string filtro = tbfilter.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos != null)
                {
                    Articulo seleccionado;
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmDetalle detalle = new frmDetalle(seleccionado);
                    detalle.ShowDialog();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione un articulo para ver el detalle, por favor");
            }
        }
    }
}



