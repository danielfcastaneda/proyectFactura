using proyectFactura.views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectFactura.model
{
    class Usuario : Persona
    {
        string contra;

        string user;

        SqlConnection connect;

        public void Ingreso(string usuario, string contrasena)
        {
            Conection cn = new Conection();
            
            connect = cn.CreateConection();
            
            connect.Open();

            string cadena = "INSERT INTO usuario VALUES ('" + usuario + "','" + contrasena + "' );";
            
            SqlCommand comando = new SqlCommand(cadena, connect);

            comando.ExecuteNonQuery();
            
            connect.Close();

        }

        public void ConnsultaUsuario(string usuario,string contrasena)
        {
            Conection cn = new Conection();
            
            connect = cn.CreateConection();

            connect.Open();

            string cadena = "SELECT nombre,contrasena FROM usuario  WHERE nombre = '" + usuario + "' and contrasena = '" + contrasena + "' ;";

            SqlCommand comando = new SqlCommand(cadena, connect);
            
            SqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read()) {

                user = resultado["nombre"].ToString();

                contra = resultado["contrasena"].ToString();

                
            }

            if (user == usuario && contra == contrasena)
            {

                principal pr = new principal();

                pr.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectas");
            }
            connect.Close();

            

        }
    }
}
