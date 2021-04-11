using proyectFactura.model;
using proyectFactura.views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectFactura.controller
{
    class CIndex
    {

        //metodo para verificar usuarios

        public void control(string usuario, string contrasena)
        {
            Usuario user = new Usuario(usuario, contrasena);

            principal.nombreUsuario = usuario;

          user.ConnsultaUsuario();

           
        }

    }
}
