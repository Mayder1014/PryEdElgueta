using System;
using System.Collections;
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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario arbol = new clsArbolBinario();
        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false; btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.codigo = Convert.ToInt32(updCodigoA.Value);
            nuevo.nombre = txtNombreA.Text;
            nuevo.tramite = txtTramiteA.Text;

            arbol.agregar(nuevo);
            arbol.recorrer(tvMostrar); arbol.recorrer(cmbEliminar);
            arbol.recorrer(dgvMostrar);
            
            updCodigoA.Value = 0;
            updCodigoA.Select(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            arbol.eliminar(Convert.ToInt32(cmbEliminar.Text));

            cmbEliminar.SelectedIndex = -1;
            arbol.recorrer(tvMostrar); arbol.recorrer(cmbEliminar);
            arbol.recorrer(dgvMostrar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsNodo aux = arbol.buscarCodigo(Convert.ToInt32(cmbEliminar.Text));


        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            arbol.equilibrar();
            arbol.recorrer(tvMostrar);
        }

        private void optIn_CheckedChanged(object sender, EventArgs e)
        {
            arbol.recorrer(dgvMostrar);
        }

        private void optPre_CheckedChanged(object sender, EventArgs e)
        {
            arbol.recorrerPre(dgvMostrar);
        }

        private void optPost_CheckedChanged(object sender, EventArgs e)
        {
            arbol.recorrerPost(dgvMostrar);
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

        private void cmbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEliminar.SelectedIndex != -1)
                btnEliminar.Enabled = true;
            else
                btnEliminar.Enabled = false;
        }

        //Estos metodos evitan que el usuario pueda escribir letras en vez de números y que pueda escribir en el comboBox
        private void cmbEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
