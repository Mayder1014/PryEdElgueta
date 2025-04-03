using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdElgueta
{
    internal class clsArchivo
    {
        public string nombreArchivo = "";
        
        //METODOS GLOBALES----------------------------------------------------------------------------------
        public void grabar()
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, true);
            AD.WriteLine("Hola");
            AD.Close();
        }

        public void grabar(string dato)
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, true);
            AD.WriteLine(dato);
            AD.Close();
        }

        public void leer(DataGridView dgv)
        {
            StreamReader AD = new StreamReader(nombreArchivo);
            string dato = "";
            dato = AD.ReadLine();
            dgv.Rows.Clear();
            while (dato != null)
            {
                dgv.Rows.Add(dato.Split(';'));
                dato = AD.ReadLine();
            }
            AD.Close();
        }

        public void leer(ComboBox cmb)
        {
            StreamReader AD = new StreamReader(nombreArchivo);
            string dato = "";
            dato = AD.ReadLine();
            cmb.Items.Clear();
            while (dato != null)
            {
                cmb.Items.Add(dato);
                dato = AD.ReadLine();
            }
            AD.Close();
        }

        public void leer(ListBox lista)
        {
            StreamReader AD = new StreamReader(nombreArchivo);
            string dato = "";
            dato = AD.ReadLine();
            lista.Items.Clear();
            while (dato != null)
            {
                lista.Items.Add(dato);
                dato = AD.ReadLine();
            }
            AD.Close();
        }

        //METODOS ESPECIFICOS -------------------------------------------------------------------------------
        public bool repetido(decimal cod)
        {
            bool repetido = false;
            StreamReader AD = new StreamReader(nombreArchivo);
            string dato = AD.ReadLine();

            while (dato != null && repetido != true)
            {
                if (cod == Convert.ToDecimal(dato.Split(';')[0]))
                {
                    repetido = true;
                }
                dato = AD.ReadLine();
            }
            AD.Close();

            if (repetido == true)
                MessageBox.Show("El codigo que intenta ingresar, ya fue asignado en otro registro.","ERROR");

            return repetido;
        }

        public bool repetido(string nuevoDato)
        {
            bool repetido = false;
            StreamReader AD = new StreamReader(nombreArchivo);
            string dato = AD.ReadLine();

            while (dato != null && repetido != true)
            {
                if (nuevoDato == dato.Split(';')[1])
                {
                    repetido = true;
                }
                dato = AD.ReadLine();
            }
            AD.Close();

            if (repetido == true)
                MessageBox.Show("La provincia que intenta ingresar, ya fue ingresada con anterioridad.", "ERROR");

            return repetido;
        }

        

    }
}
