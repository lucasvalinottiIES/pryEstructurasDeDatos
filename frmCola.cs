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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola FilaDePersonas = new clsCola();

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsNodo objNodo = new clsNodo();
                objNodo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
                objNodo.Nombre = txtNuevoNombre.Text;
                objNodo.Tramite = txtNuevoTramite.Text;
                FilaDePersonas.Agregar(objNodo);
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lstLista);
                FilaDePersonas.Recorrer();
                txtNuevoCodigo.Text = "";
                txtNuevoNombre.Text = "";
                txtNuevoTramite.Text = "";
                cmdEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                // Muestro error en caso de que ocurra.
                MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCodigo.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombre.Text = FilaDePersonas.Primero.Nombre;
                lblTramite.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lstLista);
                FilaDePersonas.Recorrer();
            }
            else 
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
            // Deshabilito el boton eliminar si la Cola esta vacia.
            if(FilaDePersonas.Primero == null) cmdEliminar.Enabled = false;
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            cmdEliminar.Enabled = false;
        }
    }
}
