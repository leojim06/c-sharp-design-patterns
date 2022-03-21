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

            Documento doc = new Documento(cliente);
            doc.Imprimir();

            Documento docFactura = new Factura(cliente);
            docFactura.Imprimir();

            Documento docNotaCredito = new NotaCredito(cliente);
            docNotaCredito.Imprimir();

            Console.ReadKey();
        }
    }
}
