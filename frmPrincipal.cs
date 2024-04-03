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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdDesarrollador_Click(object sender, EventArgs e)
        {
            frmDesarrollador frm = new frmDesarrollador();
            frm.ShowDialog();
        }

        private void cmdCola_Click(object sender, EventArgs e)
        {
            frmCola frm = new frmCola();
            frm.ShowDialog();
        }

        private void cmdPila_Click(object sender, EventArgs e)
        {
            frmPila frm = new frmPila();
            frm.ShowDialog();
        }
    }
}
