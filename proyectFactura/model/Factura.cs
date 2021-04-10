using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace proyectFactura.model
{
    class Factura
    {
        SqlConnection connect;
        public void CrearFactura(string idCliente, string nombreCliente, string apellidoCliente, string celular, string email, string genero, string vendedor)
        {
            Conection cn = new Conection();

            connect = cn.CreateConection();

            connect.Open();

            string cadena = "INSERT INTO factura VALUES ('" + idCliente + "','" + nombreCliente + "','" + apellidoCliente + "','" + celular + "','" + email + "','" + genero + "','" + vendedor + "' );";

            SqlCommand comando = new SqlCommand(cadena, connect);

            comando.ExecuteNonQuery();

            connect.Close();

        }

        public void crearFacturaXml(string idCliente, string nombreCliente, string apellidoCliente, string celular, string email, string genero, string vendedor)
        {
            XmlDocument documento = new XmlDocument();
            XmlDeclaration declaration = documento.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = documento.DocumentElement;
            documento.InsertBefore(declaration,root);

            XmlElement xEncabezado = documento.CreateElement(string.Empty, "encabezado", string.Empty);
            XmlElement xIDCliente = documento.CreateElement(string.Empty,"idCliente",string.Empty);
            XmlElement xNombreCliente = documento.CreateElement(string.Empty, "nombreCliente", string.Empty);
            XmlElement xApellidoCliente = documento.CreateElement(string.Empty, "apellidoCliente", string.Empty);
            XmlElement xCelular = documento.CreateElement(string.Empty, "celular", string.Empty);
            XmlElement xEmail = documento.CreateElement(string.Empty, "email", string.Empty);
            XmlElement xGenero = documento.CreateElement(string.Empty, "genero", string.Empty);
            XmlElement xVendedor = documento.CreateElement(string.Empty, "vendedor", string.Empty);

            documento.AppendChild(xEncabezado);
            xEncabezado.AppendChild(xIDCliente);
            xEncabezado.AppendChild(xNombreCliente);
            xEncabezado.AppendChild(xApellidoCliente);
            xEncabezado.AppendChild(xCelular);
            xEncabezado.AppendChild(xEmail);
            xEncabezado.AppendChild(xGenero);
            xEncabezado.AppendChild(xVendedor);

            XmlText tIdCliente = documento.CreateTextNode(idCliente);
            XmlText tNombreCliente = documento.CreateTextNode(nombreCliente);
            XmlText tApellidoCliente = documento.CreateTextNode(apellidoCliente);
            XmlText tCelular = documento.CreateTextNode(celular);
            XmlText tEmail = documento.CreateTextNode(email);
            XmlText tGenero = documento.CreateTextNode(genero);
            XmlText tVendedor = documento.CreateTextNode(vendedor);

            xIDCliente.AppendChild(tIdCliente);
            xNombreCliente.AppendChild(tNombreCliente);
            xApellidoCliente.AppendChild(tApellidoCliente);
            xCelular.AppendChild(tCelular);
            xEmail.AppendChild(tEmail);
            xGenero.AppendChild(tGenero);
            xVendedor.AppendChild(tVendedor);

            documento.Save("C:\\Users\\daniel.castaneda\\Desktop\\procesados\\primer_factura.xml");
        }
        
    }
}
