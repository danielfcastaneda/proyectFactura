using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectFactura.model
{
    class Referencia
    {
        SqlConnection connect;
        public void CrearReferencia(string codigo1, string codigo2, string nombreCorto, string nombreLargo, string descripcion, string precios)
        {
            Conection cn = new Conection();

            connect = cn.CreateConection();

            connect.Open();

            string cadena = "INSERT INTO referencia VALUES ('" + codigo1 + "','" + codigo2 + "','" + nombreCorto + "','" + nombreLargo + "','" + descripcion + "','" + precios + "' );";

            SqlCommand comando = new SqlCommand(cadena, connect);

            comando.ExecuteNonQuery();

            connect.Close();

        }

        
    }
}
