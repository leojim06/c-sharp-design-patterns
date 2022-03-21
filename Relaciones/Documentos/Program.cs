using Documentos.Clases;
using System;

namespace Documentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa");

            Documento doc = new Documento();
            doc.Imprimir();

            Factura docFactura = new Factura();
            docFactura.Imprimir();

            NotaCredito docNotaCredito = new NotaCredito();
            docNotaCredito.Imprimir();

            Console.ReadKey();
        }
    }
}
