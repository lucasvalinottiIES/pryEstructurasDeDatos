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
            consultaSQL = @"SELECT Titulo
                                   FROM Libro
                                   ORDER BY 1 DESC";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdProyeccionMulti_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT Titulo, Año, Precio FROM Libro ORDER BY Año Desc";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdJuntar_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT Libro.Titulo, Autor.Nombre
                            FROM Libro
                            INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdSeleccionSimple_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT * FROM Libro WHERE IdPais = 15";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdSeleccionMulti_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT * FROM Libro WHERE IdPais = 15 AND IdAutor = 18";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT * FROM (SELECT * FROM Libro WHERE IdAutor > 10) WHERE IdPais < 10";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdUnion_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT * FROM Libro WHERE IdAutor = 2
                            UNION
                            SELECT * FROM Libro WHERE IdAutor = 5";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdInterseccion_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT * FROM Libro WHERE IdIdioma
                            IN 
                            (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            BD.Listar(dgvGrilla, consultaSQL);
        }

        private void cmdDiferencia_Click(object sender, EventArgs e)
        {
            consultaSQL = @"SELECT * FROM Libro WHERE IdPais
                            NOT IN 
                            (SELECT DISTINCT IdPais FROM Libro WHERE IdPais > 5)";
            BD.Listar(dgvGrilla, consultaSQL);
        }
    }
}
