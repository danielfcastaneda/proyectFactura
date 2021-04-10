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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        //metodo para mostrar el formulario para crear clientes
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearCliente cliente = new crearCliente();

            cliente.Show();
        }

        //metodo para salir de la aplicacion

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //metodo para ver el listado de clientes
        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verClientes listado = new verClientes();

            listado.Show();

        }

        //metodo para ver el fomulario para crear nuevas referencias
        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crearReferencia nuevaReferencia = new crearReferencia();
            nuevaReferencia.Show();
        }


        //metodo para ver el listado de las referencias existentes 
        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            verReferencias referencias = new verReferencias();

            referencias.Show();


        }

        //metodo para mostrar el formulario para crear nuevas facturas
        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            crearFactura nuevaFactura = new crearFactura();
            nuevaFactura.Show();
        }
    }
}
