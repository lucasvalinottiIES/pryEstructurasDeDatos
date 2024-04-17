using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructurasDeDatos
{
    public class clsArbolBinario
    {
        #region Campos
        private clsNodo primerNodo;
        #endregion

        #region Propiedades
        public clsNodo Raiz
		{
			get { return primerNodo; }
			set { primerNodo = value; }
		}
        #endregion

        #region Metodos
        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null) Raiz = Nuevo;
            else
            {
                clsNodo Aux = Raiz;
                clsNodo Padre = Raiz;
                while (Aux != null)
                {
                    Padre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                if (Nuevo.Codigo < Padre.Codigo) Padre.Izquierdo = Nuevo;
                else Padre.Derecho = Nuevo;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void InOrdenAsc(ComboBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) InOrdenAsc(Lista, Raiz.Izquierdo);
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Derecho != null) InOrdenAsc(Lista, Raiz.Derecho);
        }

        public void InOrdenAsc(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) InOrdenAsc(Grilla, Raiz.Izquierdo);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Derecho != null) InOrdenAsc(Grilla, Raiz.Derecho);
        }

        public void PreOrden(clsNodo Raiz, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(Raiz.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (Raiz.Izquierdo != null) PreOrden(Raiz.Izquierdo, NodoPadre);
            if (Raiz.Derecho != null) PreOrden(Raiz.Derecho, NodoPadre);
        }

        #endregion

    }
}
