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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble lista = new clsListaDoble();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false; btnEliminar.Enabled = false;
            if (File.Exists("ListaDoble.csv"))
            {
                lista.agregar();
                mostrarLista();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo numero = new clsNodo();
            numero.codigo = Convert.ToInt32(updCodigoA.Value);
            numero.nombre = txtNombreA.Text;
            numero.tramite = txtTramiteA.Text;

            lista.agregar(numero);

            mostrarLista();

            updCodigoA.Value = 0; txtNombreA.Text = ""; txtTramiteA.Text = "";
            updCodigoA.Select();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(cmbEliminar.Text);

            lista.eliminar(cod);

            cmbEliminar.SelectedIndex = -1;

            mostrarLista();
        }

        //METODOS ---------------------------------------------------------------------------
        public void validarDatos()
        {
            if (updCodigoA.Value != 0 && txtNombreA.Text != "" && txtTramiteA.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else btnAgregar.Enabled = false;
        }

        public void mostrarLista()
        {
            if (optAscendente.Checked)
            {
                lista.recorrerA(); lista.recorrerA(dgvMostrar);
                lista.recorrerA(lstMostrar); lista.recorrerA(cmbEliminar); lista.recorrerA(cmbMostrar);
            } else
            {
                lista.recorrerD(); lista.recorrerD(dgvMostrar);
                lista.recorrerD(lstMostrar); lista.recorrerD(cmbEliminar); lista.recorrerA(cmbMostrar);
            }
        }

        private void updCodigoA_ValueChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtNombreA_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtTramiteA_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void cmbEliminado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEliminar.SelectedIndex != -1)
                btnEliminar.Enabled = true;
            else
                btnEliminar.Enabled = false;
        }

        //Estos metodos evitan que el usuario pueda escribir letras en vez de números y que pueda escribir en el comboBox
        private void txtNombreA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTramiteA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
    }
}
