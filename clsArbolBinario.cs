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

        public clsNodo BuscarCodigo(Int32 Codigo)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (Codigo == Aux.Codigo) break;
                if (Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }

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

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        public void PreOrden(clsNodo Raiz, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(Raiz.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (Raiz.Izquierdo != null) PreOrden(Raiz.Izquierdo, NodoPadre);
            if (Raiz.Derecho != null) PreOrden(Raiz.Derecho, NodoPadre);
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
        
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        public void InOrdenAsc(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) InOrdenAsc(Grilla, Raiz.Izquierdo);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Derecho != null) InOrdenAsc(Grilla, Raiz.Derecho);
        }
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
        public void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }
        public void PreOrden(ListBox Lst, clsNodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                PreOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Lst, R.Derecho);
            }
        }
        public void PostOrden(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                PostOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
        }


        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }
            private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        #endregion

    }
}
