using System;

namespace Documentos.Clases
{
    public class Factura : Documento
    {
        public Factura(Cliente cliente) : base(cliente: cliente) { }
        
        public override void Imprimir()
        {
            Console.WriteLine($"Factura para: {this._cliente.Presentarse()}");
            Console.WriteLine($"Imprimiendo factura No. {_numero} con fecha {_fecha}");
        }
    }
}
