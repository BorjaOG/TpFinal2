using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Service;
using System.IO;
using System.Configuration;


namespace WindowsFormsApp1
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;

        private OpenFileDialog archivo = null;
        
    
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "modificar articulo";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = (tbcodigo.Text);
                articulo.Nombre = tbnombre.Text;
                articulo.Descripcion = tbdescripcion.Text;
                articulo.ImagenUrl = tburl.Text;
                articulo.Precio = decimal.Parse(tbprecio.Text);
                articulo.Marca = (Marca)cbmarca.SelectedItem;
                articulo.Categoria = (Tipo)cbtipo.SelectedItem;

               
                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado");
                }
                //guardo imagen si la levanto localmente
                if (archivo != null && tburl.Text.ToUpper().Contains("HTPP"));
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["ArticulosApp"] + archivo.SafeFileName);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            TipoNegocio tipoNegocio = new TipoNegocio();
            try
            {
                cbmarca.DataSource = marcaNegocio.listar();
                cbmarca.ValueMember = "Id";
                cbmarca.DisplayMember = "Descripcion";
                cbtipo.DataSource = tipoNegocio.listar();
                cbtipo.ValueMember = "Id";
                cbtipo.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    tbcodigo.Text = articulo.Codigo;
                    tbnombre.Text = articulo.Nombre;
                    tbdescripcion.Text = articulo.Descripcion;
                    tburl.Text = articulo.ImagenUrl;
                    CargarImagen(articulo.ImagenUrl);
                    tbprecio.Text = articulo.Precio.ToString();
                    cbtipo.SelectedValue = articulo.Categoria.Id;
                    cbmarca.SelectedValue = articulo.Marca.Id;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void tburl_Leave(object sender, EventArgs e)
        {
            CargarImagen(tburl.Text);
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

        private void btnagregarimagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tburl.Text = archivo.FileName;
                CargarImagen(archivo.FileName);

                
            }
            
        }
    }
    }

