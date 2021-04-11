using proyectFactura.controller;
using proyectFactura.model;
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

        private static bool SeleccionMovimiento { get; set; } = false;
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

        //metodo cargar el archivo de inicio cuando se cargue el formulario
        private void principal_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("C:\\Users\\daniel.castaneda\\Desktop\\procesados\\inicio.html");
        }

        // crear evento a la imagen para que se dirija al form de visualizacion de referenciencias
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            verReferencias referencias = new verReferencias();

            referencias.Show();

        }

        // crear evento a la imagen para que se dirija al form de visualizacion de clientes
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            verClientes listado = new verClientes();

            listado.Show();

        }

        //evento para mostrar el formulario de la factura
        private void button1_Click(object sender, EventArgs e)
        {
            if (SeleccionMovimiento == true && txtBusqueda.Text == "?" ) 
            {
                crearFactura newF = new crearFactura();
                newF.Show();
                txtBusqueda.Text = "";
            }
        }

        //evento que permite conocer si se encuentra en el modulo de factura
        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionMovimiento = true;
        }
    }
}
