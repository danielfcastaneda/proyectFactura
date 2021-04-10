using proyectFactura.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectFactura.controller
{
    class Controller
    {


        public void control(string usuario, string contrasena)
        {
            Usuario user = new Usuario();

          user.ConnsultaUsuario(usuario,contrasena);

           
        }

    }
}
