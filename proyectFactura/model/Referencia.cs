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
        private string codigo1; 
        private string codigo2;
        private string nombreCorto;
        private string nombreLargo;
        private string descripcion;
        private string precios;
        SqlConnection connect;

        public  Referencia(string codigo1, string codigo2, string nombreCorto, string nombreLargo, string descripcion, string precios) 
        {
            this.codigo1 = codigo1;
            this.codigo2 = codigo2;
            this.nombreCorto = nombreCorto;
            this.nombreLargo = nombreLargo;
            this.descripcion = descripcion;
            this.precios = precios;
            
        }

        
        public void CrearReferencia()
        {
            Conection cn = new Conection();

            connect = cn.CreateConection();

            connect.Open();

            string cadena = "INSERT INTO referencia VALUES ('" + this.codigo1 + "','" + this.codigo2 + "','" + this.nombreCorto + "','" + this.nombreLargo + "','" + this.descripcion + "','" + this.precios + "' );";

            SqlCommand comando = new SqlCommand(cadena, connect);

            comando.ExecuteNonQuery();

            connect.Close();

        }

        
    }
}
