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
        private string contrasena;
        private string nombreUsuario;
        private string user;
        private string contra;
        SqlConnection connect;
        
        public Usuario(string nombreUsuario, string contrasena)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
        }
        public void Ingreso()
        {
            Conection cn = new Conection();
            
            connect = cn.CreateConection();
            
            connect.Open();

            string cadena = "INSERT INTO usuario VALUES ('" + this.nombreUsuario + "','" + this.contrasena + "' );";
            
            SqlCommand comando = new SqlCommand(cadena, connect);

            comando.ExecuteNonQuery();
            
            connect.Close();

        }

        public void ConnsultaUsuario()
        {
            

            Conection cn = new Conection();
            
            connect = cn.CreateConection();

            connect.Open();

            string cadena = "SELECT nombre,contrasena FROM usuario  WHERE nombre = '" + this.nombreUsuario + "' and contrasena = '" + this.contrasena + "' ;";

            SqlCommand comando = new SqlCommand(cadena, connect);
            
            SqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read()) 
            {

                user = resultado["nombre"].ToString();

                contra = resultado["contrasena"].ToString();

                
            }

            if (user == this.nombreUsuario && contra == this.contrasena)
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
