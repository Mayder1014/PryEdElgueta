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
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }

        clsArchivo x = new clsArchivo();
        private void frmCiudades_Load(object sender, EventArgs e)
        {
            x.nombreArchivo = "Ciudades.txt";
            if (File.Exists(x.nombreArchivo)) x.leer(lstCiudades);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                x.grabar(txtNombre.Text);
                x.leer(lstCiudades);
                MessageBox.Show("Dato cargado correctamente.");
                txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("No se ha ingresado ninguna Ciudad.", "ERROR");
            }
            
        }
    }
}
