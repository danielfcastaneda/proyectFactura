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

        public cliente(string tipoIdentificacion, string identificacion, string nombres, string apellidos, string email, string genero) 
        {
            this.tipoIdentificacion = tipoIdentificacion;
            this.identificacion = identificacion;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.genero = genero;

        }
        public void CrearCliente()
        {
            Conection cn = new Conection();

            connect = cn.CreateConection();

            connect.Open();

            string cadena = "INSERT INTO cliente VALUES ('" + this.tipoIdentificacion + "','" + this.identificacion + "','" + this.nombres + "','" + this.apellidos + "','" + this.email + "','" + this.genero + "' );";

            SqlCommand comando = new SqlCommand(cadena, connect);

            comando.ExecuteNonQuery();

            connect.Close();

        }

        
    }
}
