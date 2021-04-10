using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectFactura.model
{
       class  Conection
    {
        string server = "DESKTOP-JDR050D";
        string database = "ejemplo1";
        bool security = true;
        
         public SqlConnection CreateConection() 
        {
            SqlConnection conexion = new SqlConnection("server="+this.server+" ; database="+this.database+" ; integrated security ="+this.security);

            return conexion;
        }
    }
}
