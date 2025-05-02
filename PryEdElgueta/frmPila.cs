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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila filaPersonas = new clsPila();
        private void frmPila_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            if (File.Exists("Pila.csv"))
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

            updCodigoA.Value = 1; txtNombreA.Text = ""; txtTramiteA.Text = "";
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
            }
            else
            {
                lblCodigoMostrar.Text = "";
                lblNombreMostrar.Text = "";
                lblTramiteMostrar.Text = "";
            }
        }

        //METODOS ------------------------------------------------------------------
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
            filaPersonas.recorrer(lstMostrar);
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
