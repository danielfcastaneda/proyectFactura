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
    public partial class verReferencias : Form
    {
        public verReferencias()
        {
            InitializeComponent();
        }


        //metodo para cargar la infomacion en el form de referencias
        private void verReferencias_Load(object sender, EventArgs e)
        {
            
            
                Conection cn = new Conection();

            SqlConnection connect = cn.CreateConection();

                connect.Open();

                string cadena = "SELECT * FROM referencia;";

                SqlCommand comando = new SqlCommand(cadena, connect);

                SqlDataReader resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                textBox1.AppendText(resultado["codigo1"].ToString());
                textBox1.AppendText(resultado["codigo2"].ToString());
                textBox1.AppendText(resultado["nombreCorto"].ToString());
                textBox1.AppendText(resultado["nombreLargo"].ToString());
                textBox1.AppendText(resultado["descripcion"].ToString());
                textBox1.AppendText(resultado["precios"].ToString());

            }


                connect.Close();
            
        }
    }
}
