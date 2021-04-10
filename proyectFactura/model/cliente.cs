using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectFactura.model
{
    class cliente : Persona
    {
        SqlConnection connect;
        public void CrearCliente(string tipoIdentificacion, string identificacion, string nombres, string apellidos, string email, string genero)
        {
            Conection cn = new Conection();

            connect = cn.CreateConection();

            connect.Open();

            string cadena = "INSERT INTO cliente VALUES ('" + tipoIdentificacion + "','" + identificacion + "','" + nombres + "','" + apellidos + "','" + email + "','" + genero + "' );";

            SqlCommand comando = new SqlCommand(cadena, connect);

            comando.ExecuteNonQuery();

            connect.Close();

        }

        
    }
}
