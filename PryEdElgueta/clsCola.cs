﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEdElgueta
{
    internal class clsCola
    {
        private clsNodo pri;
        private clsNodo ult;

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
            }
            else
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
        }

        public void eliminar()
        {
            if (primero == ultimo)
            {
                primero = null;
                ultimo = null;
            } else
            {
                primero = primero.siguiente;
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
                cmb.Items.Add(aux.nombre);
                aux = aux.siguiente;
            }
        }

        public void recorrer()
        {
            clsNodo aux = primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.codigo); AD.Write(";");
                AD.Write(aux.nombre); AD.Write(";");
                AD.Write(aux.tramite);
                aux = aux.siguiente;
            }
            AD.Close();
        }

    }
}
