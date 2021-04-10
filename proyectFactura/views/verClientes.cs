using proyectFactura.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectFactura.views
{
    public partial class verClientes : Form
    {
        public verClientes()
        {
            InitializeComponent();
        }


        //metodo para cargar la infomacion en el form de clientes
        private void verClientes_Load(object sender, EventArgs e)
        {
            
            
                Conection cn = new Conection();

            SqlConnection connect = cn.CreateConection();

                connect.Open();

                string cadena = "SELECT * FROM cliente;";

                SqlCommand comando = new SqlCommand(cadena, connect);

                SqlDataReader resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                textBox1.AppendText(resultado["tipo"].ToString());
                textBox1.AppendText(resultado["id"].ToString());
                textBox1.AppendText(resultado["nombre"].ToString());
                textBox1.AppendText(resultado["apellido"].ToString());
                textBox1.AppendText(resultado["email"].ToString());
                textBox1.AppendText(resultado["genero"].ToString());

            }


                connect.Close();
            
        }
    }
}
