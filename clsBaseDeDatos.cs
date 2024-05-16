using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryEstructurasDeDatos
{
    public class clsBaseDeDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView dgvGrilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Autor";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Autor");

                dgvGrilla.DataSource = null;
                dgvGrilla.DataSource = DS.Tables["Autor"];

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public void Listar(DataGridView dgvGrilla, String instruccionSQL)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = instruccionSQL;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "ResultadoConsulta");

                dgvGrilla.DataSource = null;
                dgvGrilla.DataSource = DS.Tables["ResultadoConsulta"];

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
    }
}
