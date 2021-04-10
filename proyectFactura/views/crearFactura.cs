using proyectFactura.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectFactura.views
{
    public partial class crearFactura : Form
    {
        public crearFactura()
        {
            InitializeComponent();
        }

        //metodo para enviar los datos capturados de la nueva factura al controlador
        private void button1_Click(object sender, EventArgs e)
        {
            CCrearFactura factura = new CCrearFactura();

            factura.nuevaFactura(txtIdCliente.Text,txtNombreCliente.Text,txtApellidoCliente.Text,txtCelular.Text,txtEmail.Text,txtGenero.Text,txtVendedor.Text);
            this.Close();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
