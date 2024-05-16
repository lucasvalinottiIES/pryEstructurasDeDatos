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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDeDatos BD = new clsBaseDeDatos();
        String consultaSQL;

        private void cmdProyeccionSimple_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT Titulo, Año
                                   FROM Libro
                                   ORDER BY 1 DESC";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdProyeccionMulti_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT Nombre FROM Pais
                            INTERSECT
                            SELECT IdPais FROM LIBRO";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdJuntar_Click(object sender, EventArgs e)
        {

        }

        private void cmdSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";
            BD.Listar(dgvGrilla, consultaSQL);
        }

    }
}
