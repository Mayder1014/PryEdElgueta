using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdElgueta
{
    internal class clsArbolBinario
    {
        //Crear campo inicial del arbol, llamado raiz
        private clsNodo primerNodo;
        //Crear Vector y Variable de indice para equilibrar
        private clsNodo[] vector = new clsNodo[100]; private int i = 0;

        public clsNodo raiz
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }

        public void agregar(clsNodo nuevo)
        {
            nuevo.izquierdo = null;
            nuevo.siguiente = null;

            if  (raiz == null)
            {
                raiz = nuevo;
            } 
            else
            {
                clsNodo nodoPadre = raiz;
                clsNodo aux = raiz;
                while (aux != null)
                {
                    nodoPadre = aux;
                    if (nuevo.codigo < aux.codigo)
                    {
                        aux = aux.izquierdo;
                    } 
                    else
                    {
                        aux = aux.derecho;
                    }
                }

                if (nuevo.codigo < nodoPadre.codigo)
                {
                    nodoPadre.izquierdo = nuevo;
                } else
                {
                    nodoPadre.derecho = nuevo;
                }
            }
        }

        //Recorrido ComboBox ------------------------------------------------
        public void recorrer (ComboBox cmb)
        {
            cmb.Items.Clear();
            InOrdenAsc(cmb, raiz);
        }

        private void InOrdenAsc(ComboBox cmb, clsNodo r)
        {
            if (r.izquierdo != null)
            {
                InOrdenAsc(cmb, r.izquierdo);
            }
            cmb.Items.Add(r.codigo); //Mostrar raiz
            if (r.derecho != null)
            {
                InOrdenAsc(cmb, r.derecho);
            }
        }

        //Recorrido TreeView ------------------------------------------------
        public void recorrer (TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode nodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(nodoPadre);
            PreOrden(raiz, nodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo r, TreeNode nodoTreeView) //Para recorrer un tv SIEMPRE es con el metodo PreOrden
        {
            TreeNode nodoPadre = new TreeNode(r.codigo.ToString());
            nodoTreeView.Nodes.Add(nodoPadre);
            if (r.izquierdo != null) PreOrden(r.izquierdo, nodoPadre);
            if (r.derecho != null) PreOrden(r.derecho, nodoPadre);
        }

        //Recorrido Listbox --------------------------------------------------
        public void recorrer(ListBox lst)
        {
            lst.Items.Clear();
            InOrdenAsc(lst, raiz);
        }

        private void InOrdenAsc(ListBox lst, clsNodo r)
        {
            if (r.izquierdo != null)
            {
                InOrdenAsc(lst, r.izquierdo);
            }
            lst.Items.Add(r.codigo); //Mostrar raiz
            if (r.derecho != null)
            {
                InOrdenAsc(lst, r.derecho);
            }
        }

        //Recorrido DataGridView (3 tipos según la opción elegida)
        public void recorrer (DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrdenAsc(dgv, raiz);
        }

        public void recorrerPre(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PreOrden(dgv, raiz);
        }

        public void recorrerPost(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PostOrden(dgv, raiz);
        }

        private void InOrdenAsc(DataGridView dgv, clsNodo r)
        {
            if (r.izquierdo != null)
            {
                InOrdenAsc(dgv, r.izquierdo);
            }
            dgv.Rows.Add(r.codigo, r.nombre, r.tramite); //Mostrar raiz
            if (r.derecho != null)
            {
                InOrdenAsc(dgv, r.derecho);
            }
        }

        private void PreOrden(DataGridView dgv, clsNodo r)
        {
            dgv.Rows.Add(r.codigo, r.nombre, r.tramite); //Mostrar raiz
            if (r.izquierdo != null)
            {
                PreOrden(dgv, r.izquierdo);
            }
            if (r.derecho != null)
            {
                PreOrden(dgv, r.derecho);
            }
        }

        private void PostOrden(DataGridView dgv, clsNodo r)
        {
            if (r.izquierdo != null)
            {
                PostOrden(dgv, r.izquierdo);
            }
            if (r.derecho != null)
            {
                PostOrden(dgv, r.derecho);
            }
            dgv.Rows.Add(r.codigo, r.nombre, r.tramite); //Mostrar raiz
        }

        //Equilibrar y Eliminar (uso de los vectores) --------------------------
        public void equilibrar()
        {
            i = 0;
            grabarVectorInOrden(raiz); //Se carga de forma ascendente el arbol en un vector
            raiz = null; //Se borra el arbol
            equilibrarArbol(0, i - 1); //Se vuelve a rearmar el arbol
        }

        public void eliminar(int codigo)
        {
            i = 0;
            grabarVectorInOrden(raiz, codigo); //Se carga el vector sin el dato enviado por parametro
            raiz = null; //Se borra el arbol
            equilibrarArbol(0, i - 1); //Se vuelve a rearmar el arbol sin el dato enviado por parametro
        }

        public void grabarVectorInOrden(clsNodo nodoPadre) //Utilizado para equilibrar
        {
            if (nodoPadre.izquierdo != null)
            {
                grabarVectorInOrden(nodoPadre.izquierdo);
            }
            vector[i] = nodoPadre;
            i++;
            if (nodoPadre.derecho != null)
            {
                grabarVectorInOrden(nodoPadre.derecho);
            }
        }

        public void grabarVectorInOrden(clsNodo nodoPadre, int codigo) //Utilizado para eliminar, por eso el codigo
        {
            if (nodoPadre.izquierdo != null)
            {
                grabarVectorInOrden(nodoPadre.izquierdo, codigo);
            }
            if (nodoPadre.codigo != codigo) //Carga el vector con todos los datos, menos el del codigo pasado por parametro
            {
                vector[i] = nodoPadre;
                i++;
            }
            if (nodoPadre.derecho != null)
            {
                grabarVectorInOrden(nodoPadre.derecho, codigo);
            }
        }

        private void equilibrarArbol(int ini, int fin)
        {
            int m = (ini + fin) / 2;
            if (ini <= fin)
            {
                agregar(vector[m]); //Rearma el arbol
                equilibrarArbol(ini, m - 1); //"Parte izquierda del vec"
                equilibrarArbol(m + 1, fin); //Parte derecha del vec"
            }
        }

        //Busqueda ----------------------------------------------------------
        public clsNodo buscarCodigo(int codigo)
        {
            clsNodo aux = raiz; //Parte la busqueda desde la raiz
            while (aux != null)
            {
                if (codigo == aux.codigo) break;
                //Segun el tamaño del codigo, se mueve para la izq (menor) o der (mayor)
                if (codigo < aux.codigo) aux = aux.izquierdo;
                else aux = aux.derecho;
            }
            return aux;
        }

    }
}
