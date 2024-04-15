using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructurasDeDatos
{
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble ListaDePersonas = new clsListaDoble();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
            objNodo.Nombre = txtNuevoNombre.Text;
            objNodo.Tramite = txtNuevoTramite.Text;
            ListaDePersonas.Agregar(objNodo);
            if (optAscendente.Checked)
            {
                ListaDePersonas.Recorrer(dgvGrilla);
                ListaDePersonas.Recorrer(lstLista);
                ListaDePersonas.Recorrer(cbCodigo);
                ListaDePersonas.Recorrer();
            }
            else 
            {
                ListaDePersonas.RecorrerD(dgvGrilla);
                ListaDePersonas.RecorrerD(lstLista);
                ListaDePersonas.RecorrerD(cbCodigo);
                ListaDePersonas.RecorrerD();
            }
            txtNuevoCodigo.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (ListaDePersonas.Primero != null)
            {
                ListaDePersonas.Eliminar(Convert.ToInt32(cbCodigo.Text));
                if (optAscendente.Checked)
                {
                    ListaDePersonas.Recorrer(dgvGrilla);
                    ListaDePersonas.Recorrer(lstLista);
                    ListaDePersonas.Recorrer(cbCodigo);
                    ListaDePersonas.Recorrer();
                }
                else
                {
                    ListaDePersonas.RecorrerD(dgvGrilla);
                    ListaDePersonas.RecorrerD(lstLista);
                    ListaDePersonas.Recorrer(cbCodigo);
                    ListaDePersonas.RecorrerD();
                }
                cbCodigo.SelectedIndex = -1;

            }
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            ListaDePersonas.Recorrer(cbCodigo);
        }
    }
}
