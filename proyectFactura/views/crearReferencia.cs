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
    public partial class crearReferencia : Form
    {
        public crearReferencia()
        {
            InitializeComponent();
        }

        //metodo para enviar los datos capturados de la nueva referencia al controlador
        private void button1_Click(object sender, EventArgs e)
        {
            CCrearReferencia referencia = new CCrearReferencia();

            referencia.nuevaReferencia(txtCodigo1.Text,txtCodigo2.Text,txtNombreCorto.Text,txtNombreLargo.Text,txtDescripcion.Text,txtPrecios.Text);
            this.Close();
        }
    }
}
