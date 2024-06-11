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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            string consultaSQL = "";
            clsBaseDeDatos BD = new clsBaseDeDatos();
            switch (cboOperacion.SelectedIndex)
            {
                case 0:
                    consultaSQL = @"SELECT Nombre
                                           FROM Autor
                                           ORDER BY Nombre";
                    lblEnunciado.Text = $"PROYECCIÓN SIMPLE: Selección de todos los autores de los libros ordenados alfabeticamente";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 1:
                    lblEnunciado.Text = "PROYECCIÓN SIMPLE: Selección de todos los países ordenados alfabeticamente";
                    consultaSQL = @"SELECT Nombre
                                           FROM Pais
                                           ORDER BY Nombre";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 2:
                    lblEnunciado.Text = "PROYECCIÓN MULTIATRIBUTO: Selección de todos los titulos y precio del libro ordenados alfabeticamente";
                    consultaSQL = @"SELECT Titulo, Precio
                                           FROM Libro
                                           ORDER BY Titulo";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 3:
                    lblEnunciado.Text = "PROYECCIÓN MULTIATRIBUTO: Selección de todos los idiomas y su respectivo ID ordenados alfabeticamente";
                    consultaSQL = @"SELECT IdIdioma, Nombre
                                           FROM Idioma
                                           ORDER BY Nombre";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 4:
                    lblEnunciado.Text = "JUNTAR TABLAS: Selección de titulos, nombre de autor, nombre de pais y nombre del idioma con INNER JOIN implícito.";
                    consultaSQL = @"SELECT Libro.Titulo, Autor.Nombre, Pais.Nombre, Idioma.Nombre
                                           FROM Libro, Autor, Pais, Idioma
                                           WHERE Libro.IdAutor = Autor.IdAutor AND
                                           Libro.IdPais = Pais.IdPais AND
                                           Libro.IdIdioma = Idioma.IdIdioma
                                           ORDER BY Libro.Titulo";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 5:
                    lblEnunciado.Text = "JUNTAR TABLAS: Seleccion de titulos y nombre de autor con INNER JOIN explicito.";
                    consultaSQL = @"SELECT Libro.Titulo, Autor.Nombre
                            FROM Libro
                            INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 6:
                    lblEnunciado.Text = "SELECCIÓN SIMPLE: Seleccion de libros cuyo autor tenga ID mayor a 20";
                    consultaSQL = @"SELECT *
                            FROM Libro
                            WHERE IdAutor > 20
                            ORDER BY IdAutor";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 7:
                    lblEnunciado.Text = "SELECCIÓN SIMPLE: Seleccion de paises cuyo ID sea menor a 10";
                    consultaSQL = @"SELECT *
                            FROM Pais
                            WHERE IdPais < 10
                            ORDER BY IdPais";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 8:
                    lblEnunciado.Text = "SELECCIÓN MULTIATRIBUTO: Seleccion de libros cuyo ID de idioma sea menor a 10 y cuyo ID de Autor sea mayor a 15";
                    consultaSQL = @"SELECT *
                            FROM Libro
                            WHERE IdIdioma < 10 AND IdAutor > 15
                            ORDER BY Titulo";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 9:
                    lblEnunciado.Text = "SELECCIÓN MULTIATRIBUTO: Seleccion de libros cuyo ID de pais sea igual a 1 y cuyo ID de Autor sea igual a 19";
                    consultaSQL = @"SELECT *
                            FROM Libro
                            WHERE IdPais = 1 AND IdAutor = 19
                            ORDER BY Titulo";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 10:
                    lblEnunciado.Text = "SELECCIÓN POR CONVOLUCIÓN: Seleccion de libros cuyo ID de pais sea mayor a 7 y cuyo ID de idioma sea menor a 7";
                    consultaSQL = @"SELECT *
                            FROM (SELECT * FROM Libro WHERE IdIdioma < 7)
                            WHERE IdPais > 7
                            ORDER BY Titulo";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 11:
                    lblEnunciado.Text = "SELECCIÓN POR CONVOLUCIÓN: Seleccion de libros cuyo precio sea menor a 300 y que haya mas de uno";
                    consultaSQL = @"SELECT *
                                    FROM (SELECT * FROM Libro WHERE Precio < 300)
                                    WHERE Cantidad > 1
                                    ORDER BY Titulo";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 12:
                    lblEnunciado.Text = "UNION: Seleccion de libros cuyo precio oscile entre 650 y 700 ó libros cuya cantidad sea mayor a 10";
                    consultaSQL = @"SELECT * FROM Libro WHERE Precio > 650 AND Precio < 700
                                    UNION
                                    SELECT * FROM Libro WHERE Cantidad > 10";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 13:
                    lblEnunciado.Text = "UNION: Seleccion de paises cuyo ID sea menor a 10 o mayor a 20";
                    consultaSQL = @"SELECT * FROM Pais WHERE IdPais < 10
                                    UNION
                                    SELECT * FROM Pais WHERE IdPais > 20";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 14:
                    lblEnunciado.Text = "INTERSECCION: Seleccion de autores que tengan escrito mas de un libro.";
                    consultaSQL = @"SELECT * FROM Autor WHERE IdAutor 
                                    IN 
                                    (SELECT IdAutor FROM Libro GROUP BY IdAutor 
                                    HAVING COUNT(*) > 1)";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 15:
                    lblEnunciado.Text = "INTERSECCION: Seleccionar paises que solo tienen un libro.";
                    consultaSQL = @"SELECT * FROM Pais WHERE IdPais 
                                    IN 
                                    (SELECT IdPais FROM Libro GROUP BY IdPais 
                                    HAVING COUNT(*) = 1)";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 16:
                    lblEnunciado.Text = "DIFERENCIA: Seleccion de idiomas en los cuales no hay ningun libro escrito.";
                    consultaSQL = @"SELECT * FROM Idioma
                                    WHERE IdIdioma
                                    NOT IN
                                    (SELECT DISTINCT IdIdioma FROM Libro)";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 17:
                    lblEnunciado.Text = "DIFERENCIA: Seleccionar todos los paises que no tengan libros";
                    consultaSQL = @"SELECT * FROM Pais
                                    WHERE IdPais
                                    NOT IN
                                    (SELECT DISTINCT IdPais FROM Libro)";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 18:
                    lblEnunciado.Text = "SELECCION SIMPLE: Seleccion de idiomas cuyo ID sea mayor a 18";
                    consultaSQL = @"SELECT * FROM Idioma WHERE IdIdioma > 18";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                case 19:
                    lblEnunciado.Text = "UNION: Seleccion de Libros cuya cantidad sea menor a 5 o su autor tenga el ID igual a 3";
                    consultaSQL = @"SELECT * FROM Libro WHERE Cantidad < 5
                                    UNION
                                    SELECT * FROM Libro WHERE IdAutor = 3";
                    BD.Listar(dgvGrilla, consultaSQL);
                    break;
                default:
                    lblEnunciado.Text = "Error. No se seleccionó ninguna operación válida";
                    break;
            }
            lblEnunciado.Text += $"\n\n {consultaSQL}";
        }
    }
}

