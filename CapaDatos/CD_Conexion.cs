using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class CD_Conexion
    {
       static string cadena = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        SqlConnection conexion = new SqlConnection(cadena);
        public SqlConnection AbrirConexion() {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CerrarConexion() {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    


    }
}
