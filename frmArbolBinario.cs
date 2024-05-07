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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario Arbol = new clsArbolBinario();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsNodo Nuevo = new clsNodo();
                Nuevo.Tramite = txtNuevoTramite.Text;
                Nuevo.Nombre = txtNuevoNombre.Text;
                Nuevo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
                Arbol.Agregar(Nuevo);
                Arbol.Recorrer(dgvGrilla);
                Arbol.Recorrer(cbCodigo);
                Arbol.RecorrerPre(tvArbol);
                Arbol.Recorrer();
                txtNuevoCodigo.Text = "";
                txtNuevoNombre.Text = "";
                txtNuevoTramite.Text = "";
                cmdEquilibrar.Enabled = true;
                cbCodigo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Muestro error en caso de que ocurra.
                MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Arbol.Eliminar(Convert.ToInt32(cbCodigo.Text));
            if(Arbol.Raiz != null)
            {
                Arbol.Recorrer(dgvGrilla);
                Arbol.RecorrerPre(tvArbol);
                Arbol.Recorrer(cbCodigo);
                Arbol.Recorrer();
            }
            else
            {
                cbCodigo.Items.Clear();
                dgvGrilla.Rows.Clear();
                tvArbol.Nodes.Clear();
                cmdEliminar.Enabled = false;
                cmdEquilibrar.Enabled = false;
            }
            cbCodigo.SelectedIndex = -1;
        }

        private void cmdEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.RecorrerPre(tvArbol);
        }

        


        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            if (Arbol.Raiz == null) 
            {
                cmdEliminar.Enabled = false;
                cmdEquilibrar.Enabled = false;
            }
        }

        private void cbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCodigo.Text != "") cmdEliminar.Enabled = true;
        }
        private void optInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrdenAsc.Checked)
            {
                Arbol.Recorrer(dgvGrilla);
                Arbol.Recorrer(cbCodigo);
            }
        }
        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked)
            {
                Arbol.RecorrerPre(tvArbol);
                Arbol.RecorrerPre(dgvGrilla);
            }
            
        }
        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostOrden.Checked) Arbol.RecorrerPost(dgvGrilla);
        }

        private void optInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            if(optInOrdenDes.Checked) Arbol.RecorrerDesc(dgvGrilla);
        }
    }
}
