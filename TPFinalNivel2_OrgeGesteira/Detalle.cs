using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDetalle : Form
    {
        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulo seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            Text = "detalle articulo";
        }

        public Articulo seleccionado { get; }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                cargarImagen(seleccionado.ImagenUrl);
                tbcodigoD.Text = seleccionado.Codigo;
                tbnombreD.Text = seleccionado.Nombre;
                tbdescripcionD.Text = seleccionado.Descripcion;
                tbmarcaD.Text = seleccionado.Marca.ToString();
                tbcategoriaD.Text = seleccionado.Categoria.ToString();
                tbprecioD.Text = seleccionado.Precio.ToString();

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
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbArticulo.Load("https://worldwellnessgroup.org.au/wp-content/uploads/2020/07/placeholder.png");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

        
    

