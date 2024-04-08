using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructurasDeDatos
{
    public class clsPila
    {
        #region Campos
        private clsNodo pri;
        #endregion

        #region Propiedades
        public clsNodo Primero
		{
			get { return pri; }
			set { pri = value; }
		}
        #endregion

        #region Metodos

        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null) Primero = Nuevo;
            else
            {
                Nuevo.Siguiente= Primero;
                Primero = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero != null) Primero = Primero.Siguiente;
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while(aux != null) 
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox lista)
        {
            clsNodo aux = Primero;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Pila.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código, Nombre, Trámite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }

        #endregion

    }
}
