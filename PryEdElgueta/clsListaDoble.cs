using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdElgueta
{
    internal class clsListaDoble
    {
        //Campos de la clase
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades de la clase
        public clsNodo primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void agregar(clsNodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            } else
            {
                if (nuevo.codigo < primero.codigo)
                {
                    nuevo.siguiente = primero;
                    primero.anterior = nuevo;
                    primero = nuevo;
                }
                else
                {
                    if (nuevo.codigo > ultimo.codigo)
                    {
                        nuevo.anterior = ultimo;
                        ultimo.siguiente = nuevo;
                        ultimo = nuevo;
                    }
                    else
                    {
                        clsNodo ant = primero;
                        clsNodo aux = primero;
                        while (aux.codigo < nuevo.codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente;
                        }
                        nuevo.anterior = ant;
                        nuevo.siguiente = aux;
                        ant.siguiente = nuevo;
                        aux.anterior = nuevo;
                    }
                }
            }
        }

        public void agregar()
        {
            StreamReader AD = new StreamReader("ListaDoble.csv");
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
            if (primero.codigo == codigo && ultimo == primero)
            {
                primero = null;
                ultimo = null;
            } else
            {
                if (primero.codigo == codigo)
                {
                    primero = primero.siguiente;
                    primero.anterior = null;
                }
                else
                {
                    if (ultimo.codigo == codigo)
                    {
                        ultimo = ultimo.anterior;
                        ultimo.siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = primero;
                        clsNodo ant = primero;
                        while (aux.codigo != codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente;
                        }
                        aux = aux.siguiente;
                        ant.siguiente = aux;
                        aux.anterior = ant;
                    }
                }
            }
        }

        //RECORRER ASCENDENTE ------------------------------------------------------
        public void recorrerA(DataGridView dgv)
        {
            clsNodo aux = primero;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.codigo, aux.nombre, aux.tramite);
                aux = aux.siguiente;
            }
        }

        public void recorrerA(ListBox lst)
        {
            clsNodo aux = primero;
            lst.Items.Clear();
            while (aux != null)
            {
                lst.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }

        public void recorrerA(ComboBox cmb)
        {
            clsNodo aux = primero;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }

        public void recorrerA()
        {
            clsNodo aux = primero;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
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

        //RECORRER DESCENDENTE ------------------------------------------------------
        public void recorrerD(DataGridView dgv)
        {
            clsNodo aux = ultimo;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.codigo, aux.nombre, aux.tramite);
                aux = aux.anterior;
            }
        }

        public void recorrerD(ListBox lst)
        {
            clsNodo aux = ultimo;
            lst.Items.Clear();
            while (aux != null)
            {
                lst.Items.Add(aux.codigo);
                aux = aux.anterior;
            }
        }

        public void recorrerD(ComboBox cmb)
        {
            clsNodo aux = ultimo;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.codigo);
                aux = aux.anterior;
            }
        }

        public void recorrerD()
        {
            clsNodo aux = ultimo;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.codigo); AD.Write(";");
                AD.Write(aux.nombre); AD.Write(";");
                AD.WriteLine(aux.tramite);
                aux = aux.anterior;
            }
            AD.Close();
        }
    }
}
