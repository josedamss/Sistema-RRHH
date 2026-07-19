using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRRHH.DatosSQL
{
    internal class ConexionSQL
    {
        private readonly string cadenaConexion = "Server=localhost; Port=3306; Database=sistemarrhh; Uid=root; Pwd=Holasoyjose123@;";

        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al conectar a la Base de Datos:\n" + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conexion;
        }
    }
}

