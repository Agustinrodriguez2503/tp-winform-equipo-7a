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
using System.Configuration;

namespace Grupo_7A
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo = null;

        private OpenFileDialog archivo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                cbxMarca.SelectedIndex = -1;
                cbxCategoria.SelectedIndex = -1;

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    txtImagen.Text = articulo.Imagen;
                    txtPrecio.Text = articulo.Precio.ToString();
                    pbxAgregarArticulo.Load(articulo.Imagen);
                }

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
                pbxAgregarArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxAgregarArticulo.Load("https://img.freepik.com/vector-gratis/ups-error-404-ilustracion-concepto-robot-roto_114360-5529.jpg?semt=ais_hybrid&w=740");
            }

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Imagen = txtImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado exitosamente");
                }
                else
                {
                    if (validarCargaArticulo())
                        return;
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado exitosamente");
                }

                //negocio.agregar(articulo); //Agregar el Articulo a la Base de datos
                articulo.Id = negocio.ultimoAgregado(); //Busca el ultimo articulo (Que es el que se agrego recien)
                negocio.agregarImagen(articulo);// Para luego mandarle el articulo con su ID y poder cargarlo en la tabla IMAGENES con el ID de Articulo.             

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private bool validarCargaArticulo()
        {
            if (cbxCategoria.SelectedIndex == -1)
            {
                lblcbxCategoria.Visible = true;
                return true;

            }
            else if (cbxMarca.SelectedIndex == -1)
            {
                lblcbxCategoria.Visible = false;
                lblcbxMarca.Visible = true;
                return true;

            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                lblcbxCategoria.Visible = false;
                lblcbxMarca.Visible = false;
                lblPrecioVacio.Visible = true;
                return true;
            }
            if (!(soloNumeros(txtPrecio.Text)))
            {
                lblcbxCategoria.Visible = false;
                lblcbxMarca.Visible = false;
                lblPrecioVacio.Visible = false;
                lblSoloNumeros.Visible = true;
                txtPrecio.Text = "";
                return true;
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


    }
}
