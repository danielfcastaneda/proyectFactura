using proyectFactura.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectFactura.controller
{
    class CCrearFactura
    {

        public void nuevaFactura(string idCliente, string nombreCliente, string apellidoCliente, string celular, string email,string genero,string vendedor) 
        {
           Factura nuevaFactura = new Factura();

           nuevaFactura.crearFacturaXml(idCliente,nombreCliente,apellidoCliente,celular,email,genero,vendedor);
        }
    }
}
