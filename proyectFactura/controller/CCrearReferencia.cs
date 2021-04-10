using proyectFactura.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectFactura.controller
{
    class CCrearReferencia
    {

        public void nuevaReferencia(string codigo1, string codigo2, string nombreCorto, string nombreLargo, string descripcion,string precios) 
        {
           Referencia nuevaReferencia = new Referencia(codigo1, codigo2, nombreCorto, nombreLargo, descripcion, precios);

           nuevaReferencia.CrearReferencia();
        }
    }
}
