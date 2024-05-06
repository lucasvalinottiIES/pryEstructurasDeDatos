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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple ListaDePersonas = new clsListaSimple();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsNodo objNodo = new clsNodo();
                objNodo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
                objNodo.Nombre = txtNuevoNombre.Text;
                objNodo.Tramite = txtNuevoTramite.Text;
                ListaDePersonas.Agregar(objNodo);
                ListaDePersonas.Recorrer(dgvGrilla);
                ListaDePersonas.Recorrer(lstLista);
                ListaDePersonas.Recorrer(cbCodigo);
                ListaDePersonas.Recorrer();
                txtNuevoCodigo.Text = "";
                txtNuevoNombre.Text = "";
                txtNuevoTramite.Text = "";
                cmdEliminar.Enabled = true;
                cbCodigo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                // Muestro error en caso de que ocurra.
                MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            ListaDePersonas.Recorrer(cbCodigo);
            cmdEliminar.Enabled = false;
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if(ListaDePersonas.Primero != null)
            {
                ListaDePersonas.Eliminar(Convert.ToInt32(cbCodigo.Text));
                ListaDePersonas.Recorrer(dgvGrilla);
                ListaDePersonas.Recorrer(lstLista);
                ListaDePersonas.Recorrer(cbCodigo);
                ListaDePersonas.Recorrer();
                cbCodigo.SelectedIndex = -1;
            }
            cmdEliminar.Enabled = false;
        }

        private void cbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigo.Text != "") cmdEliminar.Enabled = true;
        }
    }
}
