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
    public partial class crearCliente : Form
    {
        public crearCliente()
        {
            InitializeComponent();
        }

        //metodo para enviar los datos capturados del nuevo cliente al controlador

        private void button1_Click(object sender, EventArgs e)
        {
            CCrearCliente cliente = new CCrearCliente();

            cliente.nuevoCliente(txtTipo.Text,txtId.Text,txtNombre.Text,txtApellido.Text,txtEmail.Text,txtGenero.Text);
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
