using proyectFactura.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectFactura.controller
{
    class CCrearCliente
    {

        public void nuevoCliente(string tipo, string id, string nombre, string apellido, string email,string genero) 
        {
            cliente nuevoCliente = new cliente(tipo, id, nombre, apellido, email, genero);

            nuevoCliente.CrearCliente();
        }
    }
}
