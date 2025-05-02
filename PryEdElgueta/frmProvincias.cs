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
    public partial class frmProvincias : Form
    {
        public frmProvincias()
        {
            InitializeComponent();
        }
        
        clsArchivo x = new clsArchivo();
        private void frmProvincias_Load(object sender, EventArgs e)
        {
            x.nombreArchivo = "Provincias.csv";
            updCodigo.Minimum = 1;
            updCodigo.Maximum = 99;
            updCodigo.Select();
            if (File.Exists(x.nombreArchivo)) x.leer(dgvProvincias);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string datos = updCodigo.Text + ";" + txtNombre.Text;

            if (txtNombre.Text != "")
            {
                if (x.repetido(updCodigo.Value) == false)
                {
                    if (x.repetido(txtNombre.Text) == false)
                    {
                        x.grabar(datos);
                        x.leer(dgvProvincias);
                        MessageBox.Show("Dato cargado correctamente.");
                    }
                }
                txtNombre.Text = "";
                updCodigo.Value = 1;
                updCodigo.Select();
            }
            else
                MessageBox.Show("No se ha ingresado ninguna Provincia", "ERROR");
        }
    }
}
