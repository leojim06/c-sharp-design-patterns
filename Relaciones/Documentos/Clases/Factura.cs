using System;

namespace Documentos.Clases
{
    public class Factura : Documento
    {
        public Factura() : base() { }
        
        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura No. {_numero} con fecha {_fecha}");
        }
    }
}
