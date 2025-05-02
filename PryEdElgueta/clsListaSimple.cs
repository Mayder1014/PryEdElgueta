using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdElgueta
{
    internal class clsListaSimple
    {
        //Campos de la clase
        private clsNodo pri;

        //Propiedades de la clase
        public clsNodo primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public void agregar(clsNodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                if (nuevo.codigo <= primero.codigo)
                {
                    nuevo.siguiente = primero;
                    primero = nuevo;
                }
                else
                {
                    clsNodo aux = primero;
                    clsNodo ant = primero; //Anterior
                    while (aux != null && nuevo.codigo > aux.codigo)
                    {
                        ant = aux;
                        aux = aux.siguiente;
                    }
                    ant.siguiente = nuevo;
                    nuevo.siguiente = aux;
                }
            }
        }

        public void agregar()
        {
            StreamReader AD = new StreamReader("ListaSimple.csv");
            string dato = AD.ReadLine(); //Tituto
            dato = AD.ReadLine(); //Reglon vacio
            dato = AD.ReadLine();
            dato = AD.ReadLine();
            while (dato != null)
            {
                clsNodo num = new clsNodo();
                string[] datos = dato.Split(';');
                num.codigo = Convert.ToInt32(datos[0]);
                num.nombre = datos[1];
                num.tramite = datos[2];

                agregar(num);
                dato = AD.ReadLine();
            }

            AD.Close();
        }


        public void eliminar(int codigo)
        {
            if (primero.codigo == codigo)
            {
                primero = primero.siguiente;
            }
            else
            {
                clsNodo aux = primero;
                clsNodo ant = primero; //Anterior
                while (codigo != aux.codigo)
                {
                    ant = aux;
                    aux = aux.siguiente;
                }
                ant.siguiente = aux.siguiente;
            }
        }



        public void recorrer(DataGridView dgv)
        {
            clsNodo aux = primero;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.codigo, aux.nombre, aux.tramite);
                aux = aux.siguiente;
            }
        }

        public void recorrer(ListBox lst)
        {
            clsNodo aux = primero;
            lst.Items.Clear();
            while (aux != null)
            {
                lst.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }

        public void recorrer(ComboBox cmb)
        {
            clsNodo aux = primero;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }

        public void recorrer()
        {
            clsNodo aux = primero;
            StreamWriter AD = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.codigo); AD.Write(";");
                AD.Write(aux.nombre); AD.Write(";");
                AD.WriteLine(aux.tramite);
                aux = aux.siguiente;
            }
            AD.Close();
        }

    }
}
