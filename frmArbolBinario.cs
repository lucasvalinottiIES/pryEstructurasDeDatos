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
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
            objNodo.Nombre = txtNuevoNombre.Text;
            objNodo.Tramite = txtNuevoTramite.Text;
            Arbol.Agregar(objNodo);
            Arbol.Recorrer(dgvGrilla);
            Arbol.Recorrer(cbCodigo);
            Arbol.Recorrer(tvArbol);

            txtNuevoCodigo.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoTramite.Text = "";
        }
    }
}
