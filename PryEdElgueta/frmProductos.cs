using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEdElgueta
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        clsArchivo x = new clsArchivo();
        private void frmProductos_Load(object sender, EventArgs e)
        {
            x.nombreArchivo = "Productos.csv";

            updPrecio.Maximum = 100000;
            llenarCombo();

            if (File.Exists(x.nombreArchivo)) x.leer(dgvProductos);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string datos = updCodigo.Text + ';' + txtNombre.Text + ";" + rTxtDescripcion.Text + ";" + updPrecio.Text + ";" + cmbCategoria.Text;

            if (camposVacios() != true)
            {
                if (x.repetido(updCodigo.Value) != true)
                {
                    if (updPrecio.Value > 0)
                    {
                        x.grabar(datos);
                        x.leer(dgvProductos);
                        MessageBox.Show("Producto cargado correctamente.", "CARGA EXITOSA");
                        restablecerValores();
                    }
                    else
                        MessageBox.Show("El precio de un producto debe ser mayor que 0.", "ERROR");
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (optCategoria.Checked)
            {
               
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {

        }

        //METODOS ------------------------------------------------------------------------------------------------------
        public void llenarCombo()
        {
            cmbCategoria.Items.Clear();
            string[] categorias = new string[] { "Electronicos", "Alimentos", "Bazar/Librería", "Limpieza", "Perfumes" };

            foreach (string cat in categorias)
            {
                cmbCategoria.Items.Add(cat);
            }
        }

        public void restablecerValores()
        {
            updCodigo.Value = 0; updPrecio.Value = 0;
            txtNombre.Text = ""; rTxtDescripcion.Text = "";
            cmbCategoria.SelectedIndex = -1;
        }

        public bool camposVacios()
        {
            bool respuesta = false;
            if (txtNombre.Text == "" || rTxtDescripcion.Text == "" || cmbCategoria.SelectedItem.ToString() == "")
            {
                respuesta = true;
                MessageBox.Show("Hay campos sin completar. Intentelo nuevamente.","ERROR");
            }
            return respuesta;
        }

    }
}
