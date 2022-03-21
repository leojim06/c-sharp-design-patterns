using Documentos.Clases;
using System;

namespace Documentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa");

            Cliente cliente = new Cliente(nombre: "Ernesto", apellido: "Perez");
            cliente.Presentarse();

            Sucursal sucursal = new Sucursal("Calle 100 - Carrera 100");

            Documento doc = new Documento(cliente);
            doc.AgregarItem("Dado", 12.50, 10);
            doc.AgregarItem("Regla", 5.20, 1);
            doc.Sucursal = sucursal;
            doc.Imprimir();

            Documento docFactura = new Factura(cliente);
            docFactura.Sucursal = sucursal;
            docFactura.Imprimir();

            Documento docNotaCredito = new NotaCredito(cliente);
            docNotaCredito.Sucursal = sucursal;
            docNotaCredito.Imprimir();

            sucursal.Agregar(doc);
            sucursal.Agregar(docFactura);
            sucursal.Agregar(docNotaCredito);

            Console.ReadKey();
        }
    }
}
