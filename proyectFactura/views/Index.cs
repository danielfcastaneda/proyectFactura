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

namespace proyectFactura
{
    public partial class Index : Form
    {

        public Index()
        {
            InitializeComponent();
        }

       
        //evento para hacer la validacion e ingresar al sistema
        
        
        private void Enviar_Click(object sender, EventArgs e)
        {
           
            CIndex control = new CIndex();
            
           control.control(txtUser.Text,txtPasword.Text);

           
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
