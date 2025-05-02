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
using System.Collections;

namespace PryEdElgueta
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola filaPersonas = new clsCola();
        private void frmCola_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            if (File.Exists("Cola.csv"))
            {
                filaPersonas.agregar();
                mostrarLista();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo persona = new clsNodo();
            persona.codigo = Convert.ToInt32(updCodigoA.Value);
            persona.nombre = txtNombreA.Text;
            persona.tramite = txtTramiteA.Text;

            filaPersonas.agregar(persona);

            mostrarLista();

            updCodigoA.Value = 0; txtNombreA.Text = ""; txtTramiteA.Text = "";
            updCodigoA.Select();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaPersonas.primero != null)
            {
                lblCodigoMostrar.Text = filaPersonas.primero.codigo.ToString();
                lblNombreMostrar.Text = filaPersonas.primero.nombre.ToString();
                lblTramiteMostrar.Text = filaPersonas.primero.tramite.ToString();

                filaPersonas.eliminar();

                mostrarLista();
            } else
            {
                lblCodigoMostrar.Text = "";
                lblNombreMostrar.Text = "";
                lblTramiteMostrar.Text = "";
            }
        }

        //METODOS -----------------------------------------------------------------------
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
            filaPersonas.recorrer(); filaPersonas.recorrer(dgvMostrar);
            filaPersonas.recorrer(lstMostrar); filaPersonas.recorrer(cmbMostrar);
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
    }
}
